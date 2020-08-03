using System;
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
Application.DoEvents();
}
KeyReg();
}

}
}