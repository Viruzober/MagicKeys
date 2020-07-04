using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace MagicKeys
{
    public partial class MagicKeys
{

public delegate bool EnumWindowsProc(IntPtr HWND, IntPtr HWNDList);

public static bool EnumWindowsProcDelegate(IntPtr HWND, IntPtr HWNDList)
{
GCHandle gch = GCHandle.FromIntPtr(HWNDList);
List<IntPtr> list = gch.Target as List<IntPtr>;
list.Add(HWND);
return true;
}

}
}