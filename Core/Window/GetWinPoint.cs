using System;
using System.Runtime.InteropServices;
using System.Text;
namespace MagicKeys
{
    public partial class MagicKeys
{
public static bool GetWinPoint(string HWNDTitle, string HWNDClass, int X, int Y)
{
WinPoint WP;
WP.X = X;
WP.Y = Y;
IntPtr Handle = WindowFromPoint(WP);
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) & Class.ToString().Contains(HWNDClass))
{
return true;
}
else
{
return false;
}
}

}
}