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
if (Ini.IniReadSettings(@".\Settings.ini", "Settings", "NavigationType") == "1")
{
NavigationType = 1;
}
else
{
NavigationType = 0;
}
if (Ini.IniReadSettings(@".\Settings.ini", "Settings", "SoundTheme") == "false")
{
SoundTheme = false;
}
else
{
SoundTheme = true;
}
TimeOut = Convert.ToInt32(Ini.IniReadSettings(@".\Settings.ini", "Settings", "TimeOut"));
if (Ini.IniReadSettings(@".\Settings.ini", "Settings", "SpeachType") == "false")
{
SpeachType = false;
}
else
{
SpeachType = true;
}
}
else
{
using (StreamWriter sw = new StreamWriter(@".\Settings.ini", true, System.Text.Encoding.Default))
{
sw.Write("[Settings]\r\nNavigationType=0\r\nSoundTheme=true\r\nTimeOut=20\r\nSpeachType=false\r\n");
}
}
}

}
}