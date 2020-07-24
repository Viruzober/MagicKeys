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
string VUIPath = @"VUI\"+(API.GetVUI().Substring(0, API.GetVUI().Length - 4)+"Load.vui");
if (File.Exists(@VUIPath) != true)
{
return;
}
int Count = Ini.IniCountSections(VUIPath);
for(int I = 0; I <= Count; I++)
{
List<string> Items = Ini.IniReadKeys(VUIPath, I.ToString());
List<string> Values = Ini.IniReadValues(VUIPath, I.ToString());
string[] Trigger = Items[0].Split("|");
if (Trigger[0] == "Img")
{
if (ImgSearch(@"Images\"+Trigger[1], true)[0] == Convert.ToInt32(Convert.ToBoolean(Trigger[2])))
{
LoadActionRun(Items.GetRange(2, Count-1), Values.GetRange(2, Count-1), Convert.ToInt32(Values[1]));
}
else if (Trigger[0] == "VUI")
{
if (Trigger[1] == API.GetVUIName())
{
LoadActionRun(Items.GetRange(2, Count-1), Values.GetRange(2, Count-1), Convert.ToInt32(Values[1]));
}
}
}
}
}

}
}