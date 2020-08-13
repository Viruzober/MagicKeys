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
NavigationType.CheckState = (CheckState)Convert.ToInt32(Ini.IniRead(@".\Settings.ini", "Settings", "NavigationType"));
SoundTheme.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SoundTheme")));
SpeakType.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SpeakType")));
Time.Value = Convert.ToDecimal(Ini.IniRead(@".\Settings.ini", "Settings", "TimeOut"));
Exit.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "Exit")));
Info.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SendInfo")));
}

public void Save_Click(object sender, EventArgs e)
{
Ini.IniWrite(@".\Settings.ini", "Settings", "NavigationType", Convert.ToInt32(NavigationType.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "SoundTheme", Convert.ToBoolean(SoundTheme.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "TimeOut", (Time.Value).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "SpeakType", Convert.ToBoolean(SpeakType.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "Exit", Convert.ToBoolean(Exit.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "SendInfo", Convert.ToBoolean(Info.Checked).ToString());
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
MagicKeys.HM.Help(null, null);
}

}
}