using System;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{
public static void WinMove(int X, int Y, bool RecP)
{
P = GetPluginCoord();
IntPtr Handle = GetForegroundWindow();
int[] Rect = GetWinRect(Handle);
if (RecP == true)
{
DP[1] = Rect[0];
DP[2] = Rect[1];
}
SetWindowPos(GetForegroundWindow(), 0, X, Y, 0, 0, MKC.SWP_NOSIZE);
Thread.Sleep(50);
P = GetPluginCoord();
}

}
}