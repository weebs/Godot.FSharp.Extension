use std::ffi::{c_char, c_void, CStr};
use netcorehost::{nethost, pdcstr};

// #[cfg(test)]
// pub mod tests {
use std::ptr::null;
use std::str::FromStr;
// use super::*;

unsafe extern "C" fn sample_fn() {
    println!("inside rust callback, invoked from f#");
    return ();
}

#[no_mangle]
unsafe extern "C" fn get_proc_address(name: *const c_char) -> unsafe extern "C" fn() {
    let name_str = CStr::from_ptr(name).to_string_lossy().into_owned();
    println!("{}", name_str);
    return sample_fn;
}

pub fn get_dll_dir() -> std::path::PathBuf {
    let baseDir = std::path::Path::new(env!("CARGO_MANIFEST_DIR"));
    let dir = baseDir.join("../Godot.Extension/bin/Debug/net8.0");
    return dir
}

// #[test]
pub fn run_dotnet() {
    let dir = get_dll_dir();
    let json_path =
        netcorehost::pdcstring::PdCString::from_str(
            dir.join("Godot.Extension.runtimeconfig.json").to_str().unwrap()
        ).unwrap();
    let dll_path =
        netcorehost::pdcstring::PdCString::from_str(
            dir.join("Godot.Extension.dll").to_str().unwrap()
        ).unwrap();
    let hostfxr = netcorehost::nethost::load_hostfxr().unwrap();
    // let context = hostfxr.initialize_for_dotnet_command_line(pdcstr!("C:\\Users\\Dave\\code\\Godot.FSharp.Extension\\Godot.Extension\\bin\\Debug\\net8.0\\Godot.Extension.dll")).unwrap();
    let context_with_json = hostfxr.initialize_for_runtime_config(json_path).unwrap();
    let fn_loader =
        context_with_json.get_delegate_loader_for_assembly(dll_path).unwrap();
    // let f = fn_loader.get_function_with_default_signature(pdcstr!("Godot.Extension.EntryPoint"), pdcstr!("example_library_init")).unwrap();
    let f = fn_loader.get_function_with_unmanaged_callers_only::<fn(
        unsafe extern "C" fn(*const c_char) -> (unsafe extern "C" fn()),
        *const c_void,
        *const c_void)
        -> u8
    >(pdcstr!("Godot.Extension.EntryPoint, Godot.Extension"), pdcstr!("example_library_init")).unwrap();
    // let init = fn_loader.get_function_with_unmanaged_callers_only::<fn()>(pdcstr!("Godot.Extension, EntryPoint"), pdcstr!("example_library_init")).unwrap();
    f(get_proc_address, null(), null());
    // let result = context.run_app();
}
// }

#[no_mangle]
pub extern "C" fn example_library_init(
    p_get_proc_address: unsafe extern "C" fn(*const c_char) -> (unsafe extern "C" fn()),
    p_library: *mut c_void,
    r_initialization: *mut c_void
) -> u8 {
    let dir = get_dll_dir();
    let json_path =
        netcorehost::pdcstring::PdCString::from_str(
            dir.join("Godot.Extension.runtimeconfig.json").to_str().unwrap()
        ).unwrap();
    let dll_path =
        netcorehost::pdcstring::PdCString::from_str(
            dir.join("Godot.Extension.dll").to_str().unwrap()
        ).unwrap();
    let hostfxr = netcorehost::nethost::load_hostfxr().unwrap();
    // let context = hostfxr.initialize_for_dotnet_command_line(pdcstr!("C:\\Users\\Dave\\code\\Godot.FSharp.Extension\\Godot.Extension\\bin\\Debug\\net8.0\\Godot.Extension.dll")).unwrap();
    let context_with_json = hostfxr.initialize_for_runtime_config(json_path).unwrap();
    let fn_loader =
        context_with_json.get_delegate_loader_for_assembly(dll_path).unwrap();
    // let f = fn_loader.get_function_with_default_signature(pdcstr!("Godot.Extension.EntryPoint"), pdcstr!("example_library_init")).unwrap();
    let f = fn_loader.get_function_with_unmanaged_callers_only::<fn(
        unsafe extern "C" fn(*const c_char) -> (unsafe extern "C" fn()),
        *const c_void,
        *const c_void)
        -> u8
    >(pdcstr!("Godot.Extension.EntryPoint, Godot.Extension"), pdcstr!("example_library_init")).unwrap();
    // let init = fn_loader.get_function_with_unmanaged_callers_only::<fn()>(pdcstr!("Godot.Extension, EntryPoint"), pdcstr!("example_library_init")).unwrap();
    return f(p_get_proc_address, p_library, r_initialization);
}

fn main() {
    run_dotnet();
}