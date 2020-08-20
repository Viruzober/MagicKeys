using System;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void WinWaitClose(string Class)
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