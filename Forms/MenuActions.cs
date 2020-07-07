using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class Menu : Form
{

public static SettingsForm WSettings;

public void Exit(object sender, EventArgs e)
{
MagicKeys.KeySwitch = 1;
MagicKeys.OptionReg();
Ni.Visible = false;
if (MagicKeys.Exit == true)
{
DialogResult result;
if (sender == null)
{
result = MessageBox.Show("Выйти", "Закрыть Magic Keys?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
}
else
{
result = MessageBox.Show("Выйти", "Закрыть Magic Keys?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
}
if (result == DialogResult.Yes)
{
Application.Exit();
return;
}
Ni.Visible = true;
MagicKeys.OptionUnReg();
MagicKeys.KeySwitch = 0;
}
else
{
MagicKeys.Speak("Пока");
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

public void Settings(object sender, EventArgs e)
{
if (WSettings == null)
{
WSettings = new SettingsForm();
WSettings.ShowDialog();
WSettings = null;
}
else
{
WSettings.Activate();
}
}

public void Register(object sender, EventArgs e)
{
RegisterForm Reg = new RegisterForm();
Reg.Show();
}

}
}