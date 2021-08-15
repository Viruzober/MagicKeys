using System;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class SettingsForm : Form
{

public void SettingsForm_Shown(object sender, EventArgs e)
{
this.Activate();
NavigationType.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "NavigationType")));
SoundTheme.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SoundTheme")));
SpeakType.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SpeakType")));
Time.Value = Convert.ToDecimal(Ini.IniRead(@".\Settings.ini", "Settings", "TimeOut"));
Exit.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "Exit")));
UpdateChannel.SelectedItem = Ini.IniRead(@".\Settings.ini", "Settings", "UpdateChannel");
CheckUpdate.CheckState = (CheckState)Convert.ToInt32(Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "CheckUpdate")));
}

public void Save_Click(object sender, EventArgs e)
{
Ini.IniWrite(@".\Settings.ini", "Settings", "NavigationType", Convert.ToBoolean(NavigationType.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "SoundTheme", Convert.ToBoolean(SoundTheme.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "TimeOut", (Time.Value).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "SpeakType", Convert.ToBoolean(SpeakType.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "Exit", Convert.ToBoolean(Exit.Checked).ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "UpdateChannel", UpdateChannel.SelectedItem.ToString());
Ini.IniWrite(@".\Settings.ini", "Settings", "CheckUpdate", Convert.ToBoolean(CheckUpdate.Checked).ToString());
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