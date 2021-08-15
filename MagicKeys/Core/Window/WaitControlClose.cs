using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void WaitControlClose(int X, int Y, string CClass)
{
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
int nChars = 256;
StringBuilder Class = new StringBuilder(nChars);
IntPtr Handle = GetWinPointHandle(X, Y);
GetClassName(Handle, Class, nChars);
if (Class.ToString() == CClass)
{
continue;
}
return;
}
}

}
}