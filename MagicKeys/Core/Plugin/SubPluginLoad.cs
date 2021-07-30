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
string[] dir = Directory.GetDirectories(Path.Combine(API.GetPluginPath(), "Subplugins"));
for (int D = 0; D <= dir.Length-1; D++)
{
if (File.Exists(dir[D]+@"\Manifest.ini") == false)
{
continue;
}
string PluginName = new DirectoryInfo(dir[D]).Name;
string IVUI = dir[D]+@"\Manifest.ini";
List<string> MainPoints = Ini.IniReadSections(IVUI);
foreach(string Point in MainPoints)
{
if (Point == "Info")
{
 continue;
}
if (Ini.IniKeyExists(IVUI, Point, "PluginClass") == true)
{
CurrentPlugin["PluginClass"] += "."+Ini.IniRead(IVUI, Point, "PluginClass");
}
else
{
CurrentPlugin["PluginClass"] += ".MagicKeys";
}
CurrentPlugin["PluginName"] += "."+PluginName;
if (ImgSearch(Ini.IniRead(IVUI, Point, "Img"), true)[0] == 1)
{
if (File.Exists(Path.Combine(dir[D], PluginName+".dll")) == true)
{
GetSubPluginType();
}
VUILoader(Ini.IniRead(IVUI, Point, "VUI"));
Speak(PluginName+" loaded");
return true;
}
else
{
CurrentPlugin["PluginName"] = CurrentPlugin["PluginName"].Split(".")[0];
CurrentPlugin["PluginClass"] = CurrentPlugin["PluginClass"].Split(".")[0];
}
}
}
return false;
}

}
}