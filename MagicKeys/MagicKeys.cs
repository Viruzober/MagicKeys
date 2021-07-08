using System;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Menu HM;

static void Main()
{
Application.ThreadException +=
(o, e) => MKDebugForm("ExceptionHook|"+e.Exception.ToString());
Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
AppDomain.CurrentDomain.UnhandledException +=
(o, e) => MKDebugForm("ExceptionHook|"+e.ExceptionObject.ToString());
if (CheckRunProc("MagicKeys") == true) return;
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
if (CheckInternet() == true)
{
Update();
}
PluginsListLoader();
Thread ThreadPluginDetector = new Thread(PluginDetector);
ThreadPluginDetector.IsBackground = true;
ThreadPluginDetector.Start();
RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
RegisterHotKey(HM.Handle, 3, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F4);
RegisterHotKey(HM.Handle, 4, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F6);
SoundPlay("Start", 0);
Speak(T._("MagicKeys is ready"));
Application.Run();
}

}
}