using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static bool SubPluginLoad()
{
SubPath = API.GetPluginName()+"Lib";
string TempPluginName = CurrentPlugin["PluginName"];
string[] dir = Directory.GetDirectories(@"Plugins\"+SubPath);
for (int D = 0; D <= dir.Length-1; D++)
{
if (File.Exists(dir[D]+@"\Manifest.ini") == false)
{
continue;
}
string IVUI = dir[D]+@"\Manifest.ini";
List<string> MainPoints = Ini.IniReadSections(IVUI);
foreach(string Point in MainPoints)
{
if (Point == "Info")
{
 continue;
}
CurrentPlugin["PluginName"] = Ini.IniRead(IVUI, Point, "PluginName");
if (ImgSearch(Ini.IniRead(IVUI, Point, "Img"), true)[0] == 1)
{
VUILoader(Ini.IniRead(IVUI, Point, "VUI"));
Speak(Ini.IniRead(IVUI, Point, "PluginName")+" loaded");
return true;
}
}
}
CurrentPlugin["PluginName"] = TempPluginName;
return false;
}

}
}