using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class Menu : Form
{

public void Exit(object sender, EventArgs e)
{
MagicKeys.UnregisterHotKey(DeveloperTool.HM.Handle, 0);
MagicKeys.UnregisterHotKey(DeveloperTool.HM.Handle, 1);
Ni.Visible = false;
DialogResult result;
if (sender == null)
{
result = MessageBox.Show("Do you really want to exit DeveloperTool?", "Exit DeveloperTool", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
}
else
{
result = MessageBox.Show("Do you really want to exit DeveloperTool?", "Exit DeveloperTool", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
}
if (result == DialogResult.OK)
{
MagicKeys.Speak("Goodbye");
Application.Exit();
return;
}
Ni.Visible = true;
MagicKeys.RegisterHotKey(DeveloperTool.HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MagicKeys.RegisterHotKey(DeveloperTool.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
}

public void Help(object sender, EventArgs e)
{
string commandText = @"Руководство пользователя.html";
var proc = new System.Diagnostics.Process();
proc.StartInfo.FileName = commandText;
proc.StartInfo.UseShellExecute = true;
proc.Start();
}

}
}