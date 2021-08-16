using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public static partial class MKLib
{

public static List<IntPtr> GetAllWindows(IntPtr Parent)
{
List<IntPtr> result = new List<IntPtr>();
GCHandle listHandle = GCHandle.Alloc(result);
EnumChildProcDelegate childProc = new EnumChildProcDelegate(EnumChildProc);
EnumChildWindows(Parent, childProc, GCHandle.ToIntPtr(listHandle));
return result;
}

}