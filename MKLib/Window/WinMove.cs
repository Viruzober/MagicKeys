using System;
using System.Threading;

public static partial class MKLib
{

public static int[] WinMove(int X, int Y)
{
IntPtr Handle = GetForegroundWindow();
int[] Rect = GetWinRect(Handle);
SetWindowPos(GetForegroundWindow(), 0, X, Y, 0, 0, MKC.SWP_NOSIZE);
Thread.Sleep(50);
return Rect;
}

}