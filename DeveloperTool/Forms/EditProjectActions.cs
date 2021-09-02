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
}

public void Click_Save(object Sender, EventArgs e)
{
var TextBoxes = this.Controls.OfType<TableLayoutPanel>().ToList()[0].Controls.OfType<TextBox>().ToList();
var TextBoxesText = TextBoxes.Select(t => t.Text).ToList();
if (TextBoxesText.Any(s => string.IsNullOrEmpty(s)) == true)
{
MessageBox.Show(T._("Error"), T._("Some fields are empty"));
return;
}
if (TextBoxesText[0] != DeveloperTool.ProjectName)
{
if (Directory.Exists(@"Projects\"+TextBoxesText[0]) == true)
{
MessageBox.Show(T._("Error"), T._("A project with the same name already exists."));
return;
}
Directory.Move("Projects/"+DeveloperTool.ProjectName, "Projects/"+TextBoxesText[0]);
}
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Name", TextBoxesText[0]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Author", TextBoxesText[1]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Email", TextBoxesText[2]);
this.Close();
}

public void Click_Cancel(object sender, EventArgs e)
{
this.Close();
}

}
}