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
MagicKeys.RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MagicKeys.RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
MagicKeys.RegisterHotKey(HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
MagicKeys.RegisterHotKey(HM.Handle, 3, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F4);
Application.Run();
}

public static void ModuleFound()
{
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
if (KeySwitch == 1) return;
if(Module != string.Empty)
{
P = GetPluginCoord();
if(P[0] == 0)
{
KeyUnReg();
Module = string.Empty;
return;
}
}
}
}

}
}