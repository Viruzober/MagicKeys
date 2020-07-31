using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUIPluginLoad()
{
if (API.GetLoad() == "Code")
{
InvokeFromString("PluginLoad");
return;
}
else if (API.GetLoad() == "VUF")
{
string VUIPath = API.GetVUIPath()+API.GetVUI()+"Load.vui";
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
if (ImgSearch(API.GetImgPath()+Trigger[1], true)[0] == Convert.ToInt32(Convert.ToBoolean(Trigger[2])))
{
string VUFPath = API.GetVUIPath()+API.GetVUI()+"Load.vuf";
List<string> VUFValues = Ini.IniReadValues(VUFPath, I.ToString());
VUFInvoke(VUFValues, Convert.ToInt32(VUIValues[1]));
}
}
else if (Trigger[0] == "VUI")
{
if (Trigger[1] == API.GetVUI())
{
string VUFPath = API.GetVUIPath()+API.GetVUI()+"Load.vuf";
List<string> VUFValues = Ini.IniReadValues(VUFPath, I.ToString());
VUFInvoke(VUFValues, Convert.ToInt32(VUIValues[1]));
}
}
}
}
}

}
}