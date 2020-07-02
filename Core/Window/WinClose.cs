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
Application.DoEvents();
Thread.Sleep(TimeOut);
if (KeySwitch == 1)
{
return true;
}
IntPtr handle = GetForegroundWindow();
GetWindowText(handle, Title, nChars);
GetClassName(handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) == true & Class.ToString().Contains(HWNDClass) == true)
{
continue;
}
return true;
}

}
}
}