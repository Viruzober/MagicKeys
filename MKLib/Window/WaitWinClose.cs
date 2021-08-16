using System;
using System.Threading;

public static partial class MKLib
{

public static void WaitWinClose(string Class)
{
while(WinExistsHandle("", Class) != IntPtr.Zero)
{
Thread.Sleep(50);
}
return;
}

}