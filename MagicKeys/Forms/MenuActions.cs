using System;
using System.Threading;
using System.Windows.Forms;
using static MKLib;
namespace MagicKeys
{

public partial class Menu : Form
{

public static SettingsForm WSettings;

public void Exit(object sender, EventArgs e)
{
MagicKeys.LockPluginDetect = true;
MagicKeys.SyncThreads.WaitOne();
SetKeyRegContext(MagicKeys.OptionKeyRegInfo);
KeyUnReg();
MagicKeys.SyncThreads.ReleaseMutex();
Ni.Visible = false;
if (Settings.Exit == true)
{
DialogResult result;
result = MessageBox.Show(T._("Do you really want to exit MagicKeys?"), T._("Exit MagicKeys"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
if (result == DialogResult.OK)
{
MKLib.Speak(T._("Goodbye"));
Application.Exit();
return;
}
Ni.Visible = true;
KeyReg();
MagicKeys.LockPluginDetect = false;
}
else
{
MKLib.Speak(T._("Goodbye"));
Application.Exit();
}
}

public void Help(object sender, EventArgs e)
{
string commandText = @"Руководство пользователя.html";
var proc = new System.Diagnostics.Process();
proc.StartInfo.FileName = commandText;
proc.StartInfo.UseShellExecute = true;
proc.Start();
}

public void SettingsShow(object sender, EventArgs e)
{
MagicKeys.LockPluginDetect = true;
MagicKeys.SyncThreads.WaitOne();
SetKeyRegContext(MagicKeys.OptionKeyRegInfo);
KeyUnReg();
MagicKeys.SyncThreads.ReleaseMutex();
if (WSettings == null || WSettings.IsDisposed == true)
{
WSettings = new SettingsForm();
WSettings.Show      ();
}
else
{
WSettings.Activate();
}
}

public void CheckUpdates(object sender, EventArgs e)
{
MagicKeys.Update("true");
}

}
}