using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool WinSearch(string HWNDTitle, string HWNDClass)
{
IntPtr Handle = WinExistsHandle(HWNDTitle, HWNDClass);
GetClassName(Handle, Class, nChars);
if(Handle != IntPtr.Zero)
{
if(IsWindowEnabled(Handle) == true && IsWindowVisible(Handle) == true && GetWindow(GetParentWindow(Handle), 0) == Handle)
{
int[] Rect = GetWinRect(Handle);
MouseClick("Left", Rect[0]+50, Rect[1]+50, 1, 0, 0, 10);
return true;
}
}
return false;
}

}
}