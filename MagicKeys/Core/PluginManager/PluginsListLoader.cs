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
string WTitle = Ini.IniRead(@"Plugins\Hosts.ini", "Hosts", "WTitle");
string WClass = Ini.IniRead(@"Plugins\Hosts.ini", "Hosts", "WClass");
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
PluginsList.Add(Point, new Dictionary<string, string>());
if (Ini.IniKeyExists(IVUI, Point, "WTitle") == true)
{
PluginsList[Point].Add("WTitle", Ini.IniRead(IVUI, Point, "WTitle"));
}
else
{
PluginsList[Point].Add("WTitle", WTitle);
}
if (Ini.IniKeyExists(IVUI, Point, "WClass") == true)
{
PluginsList[Point].Add("WClass", Ini.IniRead(IVUI, Point, "WClass"));
}
else
{
PluginsList[Point].Add("WClass", WClass);
}
PluginsList[Point].Add("PClass", Ini.IniRead(IVUI, Point, "PClass"));
PluginsList[Point].Add("BClass", Ini.IniRead(IVUI, Point, "BClass"));
PluginsList[Point].Add("VUI", Ini.IniRead(IVUI, Point, "VUI"));
PluginsList[Point].Add("PluginName", Ini.IniRead(IVUI, Point, "PluginName"));
PluginsList[Point].Add("Module", Ini.IniRead(IVUI, Point, "Module"));
}
}
if (PluginsList.Count == 0)
{
MessageBox.Show("No plugins are available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
}

}
}