using Microsoft.Collections.Extensions;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static OrderedDictionary<string, OrderedDictionary<string, string>> PluginsList = new OrderedDictionary<string, OrderedDictionary<string, string>>();
public static void PluginsListLoader()
{
string WTitle = Ini.IniRead(@"Plugins\Hosts.ini", "Hosts", "WTitle");
string WClass = Ini.IniRead(@"Plugins\Hosts.ini", "Hosts", "WClass");
string[] dir = Directory.GetDirectories(@"Plugins\");
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
PluginsList.Add(Point, new OrderedDictionary<string, string>());
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
if (Ini.IniKeyExists(IVUI, Point, "PluginClass") == true)
{
PluginsList[Point].Add("PluginClass", Ini.IniRead(IVUI, Point, "PluginClass"));
}
else
{
PluginsList[Point].Add("PluginClass", "MagicKeys");
}
PluginsList[Point].Add("VUI", Ini.IniRead(IVUI, Point, "VUI"));
PluginsList[Point].Add("PluginName", new DirectoryInfo(dir[D]).Name);
PluginsList[Point].Add("Module", Ini.IniRead(IVUI, Point, "Module"));
}
}
if (PluginsList.Count == 0)
{
MessageBox.Show(T._("No plugins are available."), T._("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
}

}
}