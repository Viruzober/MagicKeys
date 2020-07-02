using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MagicKeys
{
public partial class SettingsForm : Form
{

public void SettingsForm_Shown(object sender, EventArgs e)
{
this.Activate();
if (Ini.IniRead(@".\Settings.ini", "Settings", "NavigationType") == "1")
{
NavigationType.CheckState = CheckState.Checked;
}
if (Ini.IniRead(@".\Settings.ini", "Settings", "SoundTheme") == "true")
{
SoundTheme.CheckState = CheckState.Checked;
}
if (Ini.IniRead(@".\Settings.ini", "Settings", "SpeachType") == "true")
{
SpeachType.CheckState = CheckState.Checked;
}
Time.Value = Convert.ToDecimal(Ini.IniRead(@".\Settings.ini", "Settings", "TimeOut"));
}

public void Save_Click(object sender, EventArgs e)
{
if (NavigationType.Checked == true)
{
Ini.IniWrite(@".\Settings.ini", "Settings", "NavigationType", "1");
}
else
{
Ini.IniWrite(@".\Settings.ini", "Settings", "NavigationType", "0");
}
if (SoundTheme.Checked == true)
{
Ini.IniWrite(@".\Settings.ini", "Settings", "SoundTheme", "true");
}
else
{
Ini.IniWrite(@".\Settings.ini", "Settings", "SoundTheme", "false");
}
Ini.IniWrite(@".\Settings.ini", "Settings", "TimeOut", (Time.Value).ToString());
if (SpeachType.Checked == true)
{
Ini.IniWrite(@".\Settings.ini", "Settings", "SpeachType", "true");
}
else
{
Ini.IniWrite(@".\Settings.ini", "Settings", "SpeachType", "false");
}
MagicKeys.LoadSettings();
this.Close();

}

public void Cancel_Click(object sender, EventArgs e)
{
MagicKeys.LoadSettings();
this.Close();
}

public void Help_Click(object sender, EventArgs e)
{
string commandText = @"Руководство пользователя.html";
var proc = new System.Diagnostics.Process();
proc.StartInfo.FileName = commandText;
proc.StartInfo.UseShellExecute = true;
proc.Start();
}

}
}