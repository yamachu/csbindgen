use std::collections::HashMap;

use crate::builder::BindgenOptions;
use crate::type_meta::*;
use crate::util::*;

pub fn emit_rust_method(list: &Vec<ExternMethod>, options: &BindgenOptions) -> String {
    // configure
    let method_type_path = options.rust_method_type_path.as_str();
    let method_type_path2 = match options.rust_method_type_path.as_str() {
        "" => "".to_string(),
        x => x.to_string() + "::",
    };
    let method_prefix = &options.rust_method_prefix;
    let file_header = &options.rust_file_header;

    let mut methods_string = String::new();

    for item in list {
        let method_name = item.method_name.as_str();
        let parameters = item
            .parameters
            .iter()
            .map(|p| {
                format!(
                    "    {}: {}",
                    p.name,
                    p.rust_type.to_rust_string(method_type_path)
                )
            })
            .collect::<Vec<_>>()
            .join(",\n");

        let return_line = match &item.return_type {
            None => "".to_string(),
            Some(v) => format!(" -> {}", v.to_rust_string(method_type_path)),
        };

        let parameter_only_names = item
            .parameters
            .iter()
            .map(|p| format!("        {}", p.name))
            .collect::<Vec<_>>()
            .join(",\n");

        let template = format!(
            "
#[no_mangle]
pub unsafe extern \"C\" fn {method_prefix}{method_name}(
{parameters}    
){return_line}
{{
    {method_type_path2}{method_name}(
{parameter_only_names}
    )
}}
"
        );

        methods_string.push_str(template.as_str());
    }

    let result = format!(
        "/* automatically generated by csbindgen */

#[allow(unused)]
use ::std::os::raw::*;

{file_header}

{methods_string}
    "
    );

    result
}

pub fn emit_csharp(
    methods: &Vec<ExternMethod>,
    aliases: &HashMap<String, RustType>,
    structs: &Vec<RustStruct>,
    enums: &Vec<RustEnum>,
    options: &BindgenOptions,
) -> String {
    // configure
    let namespace = &options.csharp_namespace;
    let class_name = &options.csharp_class_name;
    let method_prefix = &options.csharp_method_prefix;
    let accessibility = &options.csharp_class_accessibility;

    let dll_name = match options.csharp_if_symbol.as_str() {
        "" => format!(
            "        const string __DllName = \"{}\";",
            options.csharp_dll_name
        ),
        _ => {
            format!(
                "#if {0}
        const string __DllName = \"{1}\";
#else
        const string __DllName = \"{2}\";
#endif
        ",
                options.csharp_if_symbol, options.csharp_if_dll_name, options.csharp_dll_name
            )
        }
    };

    let mut method_list_string = String::new();
    for item in methods {
        let method_name = &item.method_name;
        let entry_point = match options.csharp_entry_point_prefix.as_str() {
            "" => format!("{method_prefix}{method_name}"),
            x => format!("{x}{method_name}"),
        };
        let return_type = match &item.return_type {
            Some(x) => x.to_csharp_string(options, aliases),
            None => "void".to_string(),
        };

        let parameters = item
            .parameters
            .iter()
            .map(|p| {
                let mut type_name = p.rust_type.to_csharp_string(options, aliases);
                if type_name == "bool" {
                    type_name = "[MarshalAs(UnmanagedType.U1)] bool".to_string();
                }

                format!("{} {}", type_name, p.escape_name())
            })
            .collect::<Vec<_>>()
            .join(", ");

        if let Some(x) = item.escape_doc_comment() {
            method_list_string.push_str_ln(format!("        /// <summary>{}</summary>", x).as_str());
        }

        method_list_string.push_str_ln(
            format!("        [DllImport(__DllName, EntryPoint = \"{entry_point}\", CallingConvention = CallingConvention.Cdecl)]").as_str(),
        );
        if return_type == "bool" {
            method_list_string.push_str_ln("        [return: MarshalAs(UnmanagedType.U1)]");
        }
        method_list_string.push_str_ln(
            format!("        public static extern {return_type} {method_prefix}{method_name}({parameters});").as_str(),
        );
        method_list_string.push('\n');
    }

    let mut structs_string = String::new();
    for item in structs {
        let name = &item.struct_name;
        let layout_kind = if item.is_union {
            "Explicit"
        } else {
            "Sequential"
        };

        structs_string
            .push_str_ln(format!("    [StructLayout(LayoutKind.{layout_kind})]").as_str());
        structs_string
            .push_str_ln(format!("    {accessibility} unsafe partial struct {name}").as_str());
        structs_string.push_str_ln("    {");
        for field in &item.fields {
            if item.is_union {
                structs_string.push_str_ln("        [FieldOffset(0)]");
            }

            let type_name = field.rust_type.to_csharp_string(options, aliases);
            let attr = if type_name == "bool" {
                "[MarshalAs(UnmanagedType.U1)] ".to_string()
            } else {
                "".to_string()
            };

            structs_string
                .push_str(format!("        {}public {} {}", attr, type_name, field.name).as_str());
            if let TypeKind::FixedArray(digits, _) = &field.rust_type.type_kind {
                let mut digits = digits.clone();
                if digits == "0" {
                    digits = "1".to_string(); // 0 fixed array is not allowed in C#
                };

                structs_string.push_str(format!("[{}]", digits).as_str());
            }
            structs_string.push_str_ln(";");
        }
        structs_string.push_str_ln("    }");
        structs_string.push('\n');
    }

    let mut enum_string = String::new();
    for item in enums {
        let repr = match &item.repr {
            Some(x) => format!(" : {}", convert_token_enum_repr(x)),
            None => "".to_string(),
        };
        let name = &item.enum_name;
        enum_string.push_str_ln(format!("    {accessibility} enum {name}{repr}").as_str());
        enum_string.push_str_ln("    {");
        for (name, value) in &item.fields {
            let value = match value {
                Some(x) => format!(" = {x},"),
                None => ",".to_string(),
            };
            enum_string.push_str_ln(format!("        {name}{value}").as_str());
        }
        enum_string.push_str_ln("    }");
        enum_string.push('\n');
    }

    let result = format!(
        "// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
using System;
using System.Runtime.InteropServices;

namespace {namespace}
{{
    {accessibility} static unsafe partial class {class_name}
    {{
{dll_name}

{method_list_string}
    }}

{structs_string}
{enum_string}
}}
    "
    );

    result
}

fn convert_token_enum_repr(repr: &String) -> String {
    match repr.as_str() {
        "(u8)" => "byte".to_string(),
        "(u16)" => "ushort".to_string(),
        "(u32)" => "uint".to_string(),
        "(u64)" => "ulong".to_string(),
        "(i8)" => "sbyte".to_string(),
        "(i16)" => "short".to_string(),
        "(i32)" => "int".to_string(),
        "(i64)" => "long".to_string(),
        x => x.to_string(),
    }
}
