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
static void Main(string[] args)
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
SoundPlay("Error.ogg", 0);
                MessageBox.Show("This version of MagicKeys is built for 32-bit Windows, but you are running a 64-bit version. Please run a 64-bit version of MagicKeys instead.", "Error");
return;
}
#endif
if (CheckInternet() == true)
{
string UI = UserInfo(PCID());
if (UI != "Reg user")
{
RegUser = false;
MessageBox.Show("Please register by clicking Register in the tray context menu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
}
HM = new Menu();
LoadSettings();
SoundPlay("Start.ogg", 0);
Speak("MagicKeys is ready");
PluginsListLoader();
Thread ThreadPluginDetector = new Thread(new ThreadStart(PluginDetector));
ThreadPluginDetector.IsBackground = true;
ThreadPluginDetector.Start();
RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
RegisterHotKey(HM.Handle, 3, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F5);
RegisterHotKey(HM.Handle, 4, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F6);
Application.Run();
}

}
}