using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool WinClose(string HWNDTitle, string HWNDClass)
{
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
P = GetPluginCoord();
if (Array.TrueForAll(P[0..4], V => V == 0)) return true;
if (KeySwitch == 1) return true;
WaitWinClose("#32768");
IntPtr Handle = GetForegroundWindow();
GetWindowText(Handle, Title, nChars);
GetClassName(Handle, Class, nChars);
if (Title.ToString().Contains(HWNDTitle) == true && Class.ToString().Contains(HWNDClass) == true)
{
continue;
}
return true;
}
}

}
}