using System.IO;
using System.Linq;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void OpenProject()
{
Directory.CreateDirectory(@"Projects\");
string[] Manifests = Directory.GetDirectories(@"Projects\");
Manifests = Manifests.Where(m => File.Exists(m+@"\Manifest.ini")).ToArray();
foreach(var ManifestDir in Manifests)
{
string[] Points = Ini.IniReadSections(ManifestDir+@"\Manifest.ini").Where(s => s.Contains("Info") == false).ToArray();
foreach(var Point in Points)
{
if (ModuleName.Contains(Ini.IniRead(ManifestDir+@"\Manifest.ini", Point, "Module")) == true)
{
ProjectName = Ini.IniRead(ManifestDir+@"\Manifest.ini", "Info", "Name");
PointName = Point;
Speak(ProjectName+" "+T._("project is opened"));
}
}
}
}

}
}