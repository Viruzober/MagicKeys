using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Linq;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void LoadSettings()
{
if (File.Exists(@".\Settings.ini") == true)
{
Settings.NavigationType = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "NavigationType"));
Settings.SoundTheme = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SoundTheme"));
Settings.TimeOut = Convert.ToInt32(Ini.IniRead(@".\Settings.ini", "Settings", "TimeOut"));
Settings.SpeakType = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SpeakType"));
Settings.Exit = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "Exit"));
Settings.UpdateChannel = Ini.IniRead(@".\Settings.ini", "Settings", "UpdateChannel");
Settings.CheckUpdate = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "CheckUpdate"));
}
else
{
using (StreamWriter sw = new StreamWriter(@".\Settings.ini", true, System.Text.Encoding.Default))
{
string CreateSettingsFile = "[Settings]\r\n";
string[] SettingsKeys = Type.GetType("MagicKeys.Settings", false, true).GetFields().Select(t => t.Name).ToArray();
for(int i = 0; i < SettingsKeys.Length; i++)
{
CreateSettingsFile += SettingsKeys[i]+"="+Type.GetType("MagicKeys.Settings", false, false).GetFields()[i].GetValue(null).ToString()+"\r\n";
}
sw.Write(CreateSettingsFile);
}
}
}

}
}