using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool WinExists(string HWNDTitle, string HWNDClass)
{
List<IntPtr> result = new List<IntPtr>();
GCHandle listHandle = GCHandle.Alloc(result);
EnumWindowsProc CallBack = new EnumWindowsProc(EnumWindowsProcDelegate);
EnumWindows(CallBack, GCHandle.ToIntPtr(listHandle));
foreach(IntPtr handle in result)
{
GetWindowText(handle, Title, nChars);
GetClassName(handle, Class, nChars);
if (Class.ToString() != "Shell_TrayWnd")
{
if (Title.ToString().Contains(HWNDTitle) & Class.ToString().Contains(HWNDClass))
{
return true;
}
}
}
return false;
}

}
}