using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static partial class MKLib
{

public static bool EnumChildProc(IntPtr handle, IntPtr pointer)
{
GCHandle gch = GCHandle.FromIntPtr(pointer);
List<IntPtr> list = gch.Target as List<IntPtr>;
list.Add(handle);
return true;
}

}