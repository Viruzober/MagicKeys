﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using static MKLib;
using System.Text.RegularExpressions;
using System.IO;

namespace DeveloperTool
{
public partial class CreateProjectForm : Form
{

public void Form_Show(object Sender, EventArgs e)
{
this.Activate();
Module.Text = DeveloperTool.ModuleName;
}

public void Click_Create(object Sender, EventArgs e)
{
var TextBoxes = this.Controls.OfType<TableLayoutPanel>().ToList()[0].Controls.OfType<TextBox>().ToList();
var TextBoxesText = TextBoxes.Select(t => t.Text).ToList();
if (TextBoxesText.Any(s => string.IsNullOrEmpty(s)) == true)
{
MessageBox.Show(T._("Some fields are empty."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
if (Directory.Exists(@"Projects\"+TextBoxesText[0]) == true)
{
MessageBox.Show(T._("A project with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Name", TextBoxesText[0]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Author", TextBoxesText[1]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", "Info", "Email", TextBoxesText[2]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", TextBoxesText[3], "VUI", TextBoxesText[4]);
Ini.IniWrite("Projects/"+TextBoxesText[0]+"/Manifest.ini", TextBoxesText[3], "Module", TextBoxesText[5]);
CreateFile("Projects/"+TextBoxesText[0]+"/VUI/"+TextBoxesText[4]+".vui");
CreateFile("Projects/"+TextBoxesText[0]+"/VUI/"+TextBoxesText[4]+".vuf");
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