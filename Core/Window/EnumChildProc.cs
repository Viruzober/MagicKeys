using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MagicKeys
{
public partial class MagicKeys
{
[DllImport("user32.dll")]
[return: MarshalAs(UnmanagedType.Bool)]
public static extern bool EnumChildWindows(IntPtr hwndParent, EnumChildProcDelegate lpEnumFunc, IntPtr lParam);

public static bool EnumChildProc(IntPtr handle, IntPtr pointer)
{
GCHandle gch = GCHandle.FromIntPtr(pointer);
List<IntPtr> list = gch.Target as List<IntPtr>;
list.Add(handle);
return true;
}

}
}