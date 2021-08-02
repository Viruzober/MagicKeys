using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
namespace MagicKeys
{
public partial class MagicKeys
{
public delegate bool EnumChildProcDelegate(IntPtr hwnd, IntPtr lParam);
public static IntPtr ControlExistsHandle(IntPtr Parent, string HWNDTitle, string HWNDClass)
{
List<IntPtr> result = new List<IntPtr>();
GCHandle listHandle = GCHandle.Alloc(result);
EnumChildProcDelegate childProc = new EnumChildProcDelegate(EnumChildProc);
EnumChildWindows(Parent, childProc, GCHandle.ToIntPtr(listHandle));
foreach(IntPtr Handle in result)
{
GetClassName(Handle, Class, nChars);
GetWindowText(Handle, Title, nChars);
if (Title.ToString().Contains(HWNDTitle) & Class.ToString().Contains(HWNDClass))
{
return Handle;
}
}
return IntPtr.Zero;
}
}
}