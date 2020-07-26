using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void PluginLoad()
{
string VUIPath = @"VUI\"+API.GetVUI().Substring(0, API.GetVUI().Length - 4)+"Load.vui";
if (File.Exists(@VUIPath) == false)
{
return;
}
int VUICount = Ini.IniCountSections(VUIPath);
for(int I = 1; I <= VUICount; I++)
{
List<string> VUIItems = Ini.IniReadKeys(VUIPath, I.ToString());
List<string> VUIValues = Ini.IniReadValues(VUIPath, I.ToString());
string[] Trigger = VUIValues[0].Split("|");
if (Trigger[0] == "Img")
{
if (ImgSearch(@"Images\"+Trigger[1], true)[0] == Convert.ToInt32(Convert.ToBoolean(Trigger[2])))
{
string VUFPath = @"VUI\"+API.GetVUI().Substring(0, API.GetVUI().Length - 4)+"Load.vuf";
List<string> VUFValues = Ini.IniReadValues(VUFPath, I.ToString());
LoadInvoke(VUFValues, Convert.ToInt32(VUIValues[1]));
}
}
else if (Trigger[0] == "VUI")
{
if (Trigger[1] == API.GetVUIName())
{
string VUFPath = @"VUI\"+API.GetVUI().Substring(0, API.GetVUI().Length - 4)+"Load.vuf";
List<string> VUFValues = Ini.IniReadValues(VUFPath, I.ToString());
LoadInvoke(VUFValues, Convert.ToInt32(VUIValues[1]));
}
}
}
}

}
}