using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static DevMenu HM;

[STAThread]
static void Main()
{
Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains("MagicKeys")) > 0)
{
MessageBox.Show("You must close MagicKeys to run DeveloperTool.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
HM = new DevMenu();
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