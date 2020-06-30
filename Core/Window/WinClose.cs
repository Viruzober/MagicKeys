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
if (WinActive(HWNDTitle, HWNDClass) == true)
{
if (Title.ToString().Contains(HWNDTitle) & Class.ToString().Contains(HWNDClass))
{
continue;
}
}
return true;
}

}
}
}