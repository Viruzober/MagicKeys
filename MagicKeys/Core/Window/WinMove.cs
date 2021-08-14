using System;
using System.Threading;

namespace MagicKeys
{

public partial class MagicKeys
{

public static int[] WinMove(int X, int Y)
{
Coords = GetModuleCoords(CurrentPlugin["Module"]);
IntPtr Handle = GetForegroundWindow();
int[] Rect = GetWinRect(Handle);
SetWindowPos(GetForegroundWindow(), 0, X, Y, 0, 0, MKC.SWP_NOSIZE);
Thread.Sleep(50);
Coords = GetModuleCoords(CurrentPlugin["Module"]);
return Rect;
}

}
}