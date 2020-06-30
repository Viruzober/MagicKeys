using System;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

        public static void WindowMover(int X, int Y, bool RecP)
        {
P = Mes();
IntPtr Handle = GetParentWindow(GetWinPointHandle(P[1], P[2]));
int[] Rect = GetWinRect(Handle);
            if (RecP == true)
            {
DP[1] = Rect[0];
DP[2] = Rect[1];
}
MouseClickDrag("Left", Rect[0]+20, Rect[1]+10, X+20, Y+10, 0, 10);
P = Mes();
}

}
}