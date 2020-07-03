using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool WinClose(string HWNDTitle, string HWNDClass)
{
SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE);
while(true)
{
P = Mes();
Thread.Sleep(50);
Application.DoEvents();
if (KeySwitch == 1)
{
return true;
}
IntPtr Handle = GetForegroundWindow();
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) == true & Class.ToString().Contains(HWNDClass) == true)
{
Application.DoEvents();
continue;
}
Application.DoEvents();
return true;
}

}
}
}