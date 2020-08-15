using System;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Security.Permissions;

namespace MagicKeys
{
public partial class MagicKeys
{

public static Menu HM;

[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
[STAThread]
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
HM = new Menu();
LoadSettings();
if (SendInfoFlag == true)
{
if (CheckInternet() == true)
{
SendInfo();
}
}
PluginsListLoader();
Thread ThreadPluginDetector = new Thread(new ThreadStart(PluginDetector));
ThreadPluginDetector.IsBackground = true;
ThreadPluginDetector.Start();
RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
RegisterHotKey(HM.Handle, 3, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F5);
RegisterHotKey(HM.Handle, 4, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F6);
SoundPlay("Start", 0);
Speak(T._("MagicKeys is ready"));
Application.Run();
}

}
}