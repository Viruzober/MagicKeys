using System;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void LoadSettings()
{
if (File.Exists(@".\Settings.ini") == true)
{
NavigationType = Convert.ToInt32(Ini.IniRead(@".\Settings.ini", "Settings", "NavigationType"));
SoundTheme = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SoundTheme"));
TimeOut = Convert.ToInt32(Ini.IniRead(@".\Settings.ini", "Settings", "TimeOut"));
SpeakType = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "SpeakType"));
Exit = Convert.ToBoolean(Ini.IniRead(@".\Settings.ini", "Settings", "Exit"));
UpdCH = Ini.IniRead(@".\Settings.ini", "Settings", "UpdCH");
}
else
{
using (StreamWriter sw = new StreamWriter(@".\Settings.ini", true, System.Text.Encoding.Default))
{
sw.Write("[Settings]\r\nNavigationType=0\r\nSoundTheme=true\r\nTimeOut=20\r\nSpeakType=false\r\nExit=true\r\nUpdCH=Release\r\n");
}
}
}

}
}