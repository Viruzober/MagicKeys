using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static int[] GetWinRect(IntPtr Handle)
{
WinRect WR;
GetWindowRect(Handle, out WR);
int[] Rect = new int[4] {WR.Left, WR.Top, WR.Right, WR.Bottom};
return Rect;
}

}
}