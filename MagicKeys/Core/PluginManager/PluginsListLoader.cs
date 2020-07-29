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

public static Dictionary<string, Dictionary<string, string>> PluginsList = new Dictionary<string, Dictionary<string, string>>();

public static void PluginsListLoader()
{
string[] dir = Directory.GetDirectories(@".\Plugins");
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
PluginsList.Add(Point, new Dictionary<string, string>());
PluginsList[Point].Add("WTitle", Ini.IniRead(IVUI, Point, "WTitle"));
PluginsList[Point].Add("WClass", Ini.IniRead(IVUI, Point, "WClass"));
PluginsList[Point].Add("PClass", Ini.IniRead(IVUI, Point, "PClass"));
if (Ini.IniRead(IVUI, Point, "BClass") == "None")
{
PluginsList[Point].Add("BClass", "None");
}
else
{
PluginsList[Point].Add("BClass", GetFullClassName(Ini.IniRead(IVUI, Point, "BClass")));
}
PluginsList[Point].Add("VUI", Ini.IniRead(IVUI, Point, "VUI"));
PluginsList[Point].Add("VUIName", Ini.IniRead(IVUI, Point, "VUIName"));
PluginsList[Point].Add("Module", Ini.IniRead(IVUI, Point, "Module"));
}
}
}

}
}