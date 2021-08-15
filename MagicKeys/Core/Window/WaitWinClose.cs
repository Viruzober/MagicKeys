using System;
using System.Threading;

namespace MagicKeys
{

public partial class MagicKeys
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
}