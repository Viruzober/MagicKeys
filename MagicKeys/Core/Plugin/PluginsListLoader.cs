using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
namespace MagicKeys
{

public partial class MagicKeys
{

public static void PluginsListLoader()
{
string WTitle = Ini.IniRead(@"Plugins\Hosts.ini", "Hosts", "WTitle");
string WClass = Ini.IniRead(@"Plugins\Hosts.ini", "Hosts", "WClass");
string[] PluginsDir = Directory.GetDirectories(@"Plugins\");
foreach(string PluginDir in PluginsDir)
{
if (File.Exists(PluginDir+@"\Manifest.ini") == false)
{
continue;
}
string ManifestFile = Path.Combine(PluginDir, "Manifest.ini");
PluginContainer TempPluginContainer = new PluginContainer();
TempPluginContainer.PluginName   = new DirectoryInfo(PluginDir).Name;
TempPluginContainer.Info.Name = Ini.IniRead(ManifestFile, "Info", "Name");
TempPluginContainer.Info.Author = Ini.IniRead(ManifestFile, "Info", "Author");
TempPluginContainer.Info.Email = Ini.IniRead(ManifestFile, "Info", "Email");
List<string> MainPoints = Ini.IniReadSections(ManifestFile).Where(p => p != "Info").ToList();
foreach(string PointName in MainPoints)
{
PluginPointContainer TempPluginPointContainer = new PluginPointContainer();
TempPluginPointContainer.Name = PointName;
if (Ini.IniKeyExists(ManifestFile, PointName, "WTitle") == true)
{
TempPluginPointContainer.WTitle = Ini.IniRead(ManifestFile, PointName, "WTitle");
}
else
{
TempPluginPointContainer.WTitle = WTitle;
}
if (Ini.IniKeyExists(ManifestFile, PointName, "WClass") == true)
{
TempPluginPointContainer.WClass = Ini.IniRead(ManifestFile, PointName, "WClass");
}
else
{
TempPluginPointContainer.WClass = WClass;
}
if (Ini.IniKeyExists(ManifestFile, PointName, "PluginClass") == true)
{
TempPluginPointContainer.PluginClass = Ini.IniRead(ManifestFile, PointName, "PluginClass");
}
else
{
TempPluginPointContainer.PluginClass = "lua";
}
TempPluginPointContainer.StartVUI = Ini.IniRead(ManifestFile, PointName, "VUI");
TempPluginPointContainer.Module = Ini.IniRead(ManifestFile, PointName, "Module");
TempPluginContainer.Points.Add(TempPluginPointContainer);
}
Plugins.Add(TempPluginContainer);
}
if (Plugins.Count == 0)
{
MessageBox.Show(T._("No plugins are available."), T._("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
}

}
}