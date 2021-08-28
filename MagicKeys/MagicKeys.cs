using static MKLib;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static Menu HM;
public static KeyInfo OptionKeyRegInfo = new KeyInfo();
public static List<string> OptionKeyList = new List<string>();

[STAThread]
static void Main()
{
Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
Application.ThreadException +=
(o, e) => MKDebugForm("ExceptionHook|"+e.Exception.ToString());
Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
AppDomain.CurrentDomain.UnhandledException +=
(o, e) => MKDebugForm("ExceptionHook|"+e.ExceptionObject.ToString());
if (CheckRunProc("MagicKeys") == true)
{
return;
}
#if X86
if (OS() == "64")
{
SoundPlay("Error", 0);
MessageBox.Show(T._("This version of MagicKeys is built for 32-bit Windows, but you are running a 64-bit version. Please run a 64-bit version of MagicKeys instead."), T._("Error"));
return;
}
#endif
var RunProc = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
if (RunProc.Count(p => p.ProcessName.Contains("DeveloperTool")) > 0)
{
MessageBox.Show(T._("You must close DeveloperTool to run MagicKeys."), T._("Error"));
return;
}
HM = new Menu();
LoadSettings();
if (Settings.CheckUpdate == true)
{
Update();
}

PluginsListLoader();
Thread ThreadPluginDetector = new Thread(PluginDetector);
ThreadPluginDetector.IsBackground = true;
ThreadPluginDetector.Start();
OptionKeyList.AddRange(new string[] {"Ctrl+Shift+F1", "Ctrl+Shift+F2", "Ctrl+Shift+F4", "Ctrl+Shift+F6"} );
OptionKeyRegInfo.WNDProcHandle = HM.Handle;
OptionKeyRegInfo.KeyList = OptionKeyList;
SetKeyRegContext(OptionKeyRegInfo);
KeyReg();
SoundPlay("Start", false);
Speak(T._("MagicKeys is ready"));
Application.Run();
}

}
}