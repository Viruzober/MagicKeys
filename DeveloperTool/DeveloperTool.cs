using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static Menu HM;

[STAThread]
static void Main()
{
HM = new Menu();
MagicKeys.Speak("DeveloperTool is ready");
OptionKeyReg();
Application.Run();
}

public static void ModuleFound()
{
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
if (DeveloperTool.KeySwitch == 1) return;
if(Module != string.Empty)
{
P = GetPluginCoord();
if(P[0] == 0)
{
Module = string.Empty;
return;
}
}
}
}

}
}