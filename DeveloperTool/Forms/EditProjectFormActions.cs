using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using static MKLib;
using System.Text.RegularExpressions;
using System.IO;
namespace DeveloperTool
{
public partial class EditProjectForm : Form
{

public void Form_Show(object Sender, EventArgs e)
{
this.Activate();
ProjectName.Text = DeveloperTool.ProjectName;
Author.Text = Ini.IniRead("Projects/"+ProjectName.Text+"/Manifest.ini", "Info", "Author");
Email.Text = Ini.IniRead("Projects/"+ProjectName.Text+"/Manifest.ini", "Info", "Email");
PointName.Text = DeveloperTool.PointName;
VUI.Text = DeveloperTool.VUIName;
Module.Text = Ini.IniRead("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", DeveloperTool.PointName, "Module");
}

public void Click_Save(object Sender, EventArgs e)
{
var TextBoxes = this.Controls.OfType<TableLayoutPanel>().ToList()[0].Controls.OfType<TextBox>().ToList();
var TextBoxesText = TextBoxes.Select(t => t.Text).ToList();
if (TextBoxesText.Any(s => string.IsNullOrEmpty(s)) == true)
{
MessageBox.Show(T._("Some fields are empty."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
if (Directory.Exists("Projects/"+TextBoxesText[0]) == true)
{
MessageBox.Show(T._("A project with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
if (File.Exists("Projects/"+DeveloperTool.VUIName+"/VUI/"+TextBoxesText[4]+".vui") == true)
{
MessageBox.Show(T._("A VUI with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
if (TextBoxesText[4] != DeveloperTool.VUIName)
{
File.Move("Projects/"+DeveloperTool.ProjectName+"/VUI/"+DeveloperTool.VUIName+".vui", "Projects/"+DeveloperTool.ProjectName+"/VUI/"+TextBoxesText[4]+".vui");
File.Move("Projects/"+DeveloperTool.ProjectName+"/VUI/"+DeveloperTool.VUIName+".vuf", "Projects/"+DeveloperTool.ProjectName+"/VUI/"+TextBoxesText[4]+".vuf");
}
if (TextBoxesText[0] != DeveloperTool.ProjectName)
{
Directory.Move("Projects/"+DeveloperTool.ProjectName, "Projects/"+TextBoxesText[0]);
}
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Name", TextBoxesText[0]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Author", TextBoxesText[1]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Email", TextBoxesText[2]);
Ini.IniRenameSection("Projects/"+TextBoxesText[0]+"/Manifest.ini", DeveloperTool.PointName, TextBoxesText[3]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", TextBoxesText[3], "VUI", TextBoxesText[4]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", TextBoxesText[3], "Module", TextBoxesText[5]);
this.DialogResult = DialogResult.OK;
this.Close();
}

public void Click_Cancel(object sender, EventArgs e)
{
this.DialogResult = DialogResult.Cancel;
this.Close();
}

}
}