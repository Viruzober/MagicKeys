using System;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

        public static void WindowMover(int X, int Y, bool RecP)
        {
IntPtr Handle = GetForegroundWindow();
int[] Rect = GetWinRect(Handle);
            if (RecP == true)
            {
DP[1] = Rect[0];
DP[2] = Rect[1];
}
Thread.Sleep(20);
SetWindowPos(GetForegroundWindow(), 0, X, Y, 0, 0, MKC.SWP_NOSIZE);
Thread.Sleep(20);
}

}
}