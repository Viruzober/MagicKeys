using System;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void WaitPluginClose(string HWNDTitle, string HWNDClass)
{
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
Coords = GetModuleCoords(CurrentPlugin["Module"]);
if (Coords == new ModuleCoords())
{
return;
}
if (KeySwitch == 1)
{
return;
}
WaitWinClose("#32768");
if (WinClosed(HWNDTitle, HWNDClass) == true) return;
}
}

}
}