#[allow(unused)]
use ::std::os::raw::*;

pub struct Foo {
    pub a: i32
}

pub struct my_special_context(Arc<Foo>);

#[no_mangle]
pub unsafe extern "C" fn init_my_special_context(src: NonNull<Box<my_special_context>>) -> bool {}

#[no_mangle]
pub unsafe extern "C" fn free_my_special_context(src: &my_special_context) -> bool {}
