using System;
using System.Threading;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void WaitWinClose(string Class)
{
if (WinExistsHandle("", Class) == IntPtr.Zero)
{
return;
}
KeyUnReg();
while(WinExistsHandle("", Class) != IntPtr.Zero)
{
Thread.Sleep(50);
}
KeyReg();
return;
}

}
}