﻿using System.IO;
using System.Linq;
using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void EditProject()
{
if (ProjectName == string.Empty)
{
Speak(T._("Project is not opened"));
return;
}
KeyUnReg();
EditProjectForm EPF = new EditProjectForm();
EPF.ShowDialog();
if (EPF.DialogResult == DialogResult.OK)
{
OpenProject();
}
KeyReg();
}

}
}