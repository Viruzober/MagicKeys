using System;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{
public static void WaitControlClose(int X, int Y, string CClass)
{
KeyUnReg();
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
IntPtr Handle = GetWinPointHandle(X, Y);
GetClassName(Handle, Class, nChars);
if (Class.ToString() == CClass)
{
continue;
}
KeyReg();
return;
}
}

}
}