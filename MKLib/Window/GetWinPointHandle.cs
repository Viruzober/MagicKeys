using System;

public static partial class MKLib
{

public static IntPtr GetWinPointHandle(int X, int Y)
{
WinPoint WP;
WP.X = X;
WP.Y = Y;
IntPtr Handle = WindowFromPoint(WP);
return Handle;
}

}