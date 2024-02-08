using System.Runtime.InteropServices;

namespace Godot.Extension;

public static unsafe class EntryPoint
{
    [UnmanagedCallersOnly]
    public static byte example_library_init(delegate*<char*, delegate*<void>> p_get_proc_address, void* p_library, void* r_initialization)
    {
        try
        {
            Library.init(
                Marshal.GetDelegateForFunctionPointer<Library.GDExtensionInterfaceGetProcAddress>(new IntPtr(p_get_proc_address)),
                new IntPtr(p_library),
                (Library.GDExtensionInitialization*)r_initialization
            );
            Console.WriteLine("Hello, world!");
            return 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine("oof");
            Console.WriteLine(ex.ToString());
        }

        return 1;
    }
}