// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
using System;
using System.Runtime.InteropServices;

namespace CsBindgen
{
    internal static unsafe partial class LibRust
    {
        const string __DllName = "csbindgen_tests";

        [DllImport(__DllName, EntryPoint = "my_add", CallingConvention = CallingConvention.Cdecl)]
        public static extern int my_add(int x, int y);

        [DllImport(__DllName, EntryPoint = "my_bool", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool my_bool([MarshalAs(UnmanagedType.U1)] bool x, [MarshalAs(UnmanagedType.U1)] bool y, [MarshalAs(UnmanagedType.U1)] bool z, bool* xr, bool* yr, bool* zr);

        [DllImport(__DllName, EntryPoint = "unsafe_return_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* unsafe_return_string();

        [DllImport(__DllName, EntryPoint = "unsafe_return_string2", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* unsafe_return_string2();

        [DllImport(__DllName, EntryPoint = "unsafe_destroy_string", CallingConvention = CallingConvention.Cdecl)]
        public static extern void unsafe_destroy_string(String* s);

        [DllImport(__DllName, EntryPoint = "create_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern Context* create_context();

        [DllImport(__DllName, EntryPoint = "delete_context", CallingConvention = CallingConvention.Cdecl)]
        public static extern void delete_context(Context* context);


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct Context
    {
        [MarshalAs(UnmanagedType.U1)] public bool foo;
    }

    
}
    