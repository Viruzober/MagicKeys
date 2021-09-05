using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using static MKLib;
using System.Windows.Forms;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void CreateProject()
{
Directory.CreateDirectory(@"Projects\");
string[] Manifests = Directory.GetDirectories(@"Projects\");
Manifests = Manifests.Where(m => File.Exists(m+@"\Manifest.ini")).ToArray();
foreach(var ManifestDir in Manifests)
{
string[] Points = Ini.IniReadSections(ManifestDir+@"\Manifest.ini").Where(s => s.Contains("[Info]") == false).ToArray();
foreach(var Point in Points)
{
if (ModuleName.Contains(Ini.IniRead(ManifestDir+@"\Manifest.ini", Point, "Module")) == true)
{
Speak(T._("The project for this module already exists"));
return;
}
}
}
KeyUnReg();
CreateProjectForm CPF = new CreateProjectForm();
CPF.ShowDialog();
if (CPF.DialogResult == DialogResult.OK)
{
OpenProject();
}
KeyReg();
}

}
}