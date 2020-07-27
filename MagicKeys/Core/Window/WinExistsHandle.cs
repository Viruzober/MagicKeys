using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static IntPtr WinExistsHandle(string HWNDTitle, string HWNDClass)
{
List<IntPtr> result = new List<IntPtr>();
GCHandle listHandle = GCHandle.Alloc(result);
EnumWindowsProc CallBack = new EnumWindowsProc(EnumWindowsProcDelegate);
EnumWindows(CallBack, GCHandle.ToIntPtr(listHandle));
foreach(IntPtr Handle in result)
{
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) & Class.ToString().Contains(HWNDClass))
{
return Handle;
}
}
return IntPtr.Zero;
}

}
}