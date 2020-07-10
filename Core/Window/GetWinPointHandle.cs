using System;
using System.Text;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static IntPtr GetWinPointHandle(int X, int Y)
{
WinPoint WP;
WP.X = X;
WP.Y = Y;
IntPtr Handle = WindowFromPoint(WP);
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
return Handle;
}

}
}