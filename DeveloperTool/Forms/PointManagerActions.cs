using System;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using static MKLib;

namespace DeveloperTool
{
public partial class PointManagerForm : Form
{

public void Form_Show(Object Sender, EventArgs e)
{
this.Activate();
var ReadPoints = Ini.IniReadSections("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini").Where(s => s.Contains("Info") == false).ToList();
ReadPoints[0] = ReadPoints[0]+" (Default)";
Points.Items.AddRange(ReadPoints.ToArray());
Points.SelectedIndex = 0;
Edit.Enabled = false;
Delete.Enabled = false;
}

public void ChangeSelectPoint(object Sender, EventArgs e)
{
if (Points.SelectedIndex == 0)
{
Edit.Enabled = false;
Delete.Enabled = false;
return;
}
Edit.Enabled = true;
Delete.Enabled = true;
}

public void AddPoint(Object Sender, EventArgs e)
{
string AddNewPoint = InputTextBox(T._("Entry Point Name"), T._("Enter new entry point name."));
if (AddNewPoint == null) return;
if (Ini.IniSectionExists("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", AddNewPoint) == true)
{
MessageBox.Show(T._("An entry point with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
Ini.IniAddSection("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", AddNewPoint);
Points.Items.Add(AddNewPoint);
}

public async void DeletePoint(object Sender, EventArgs e)
{
DialogResult result = await Task.Run(() => MessageBox.Show(T._("Do you really want to delete the selected entry point?"), T._("Delete Entry Point"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification));
if (result == DialogResult.OK)
{
Ini.IniDeleteSection("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", Points.SelectedItem.ToString());
var ReadPoints = Ini.IniReadSections("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini").Where(s => s.Contains("Info") == false).ToList();
ReadPoints[0] = ReadPoints[0]+" (Default)";
Points.Items.Clear();
Points.Items.AddRange(ReadPoints.ToArray());
Points.SelectedIndex = 0;
}
}

public void EditPoint(object Sender, EventArgs e)
{
PointEditorForm PE = new PointEditorForm(Points.SelectedItem.ToString(), AllVUI, AllModules);
PE.ShowDialog();
var ReadPoints = Ini.IniReadSections("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini").Where(s => s.Contains("Info") == false).ToList();
ReadPoints[0] = ReadPoints[0]+" (Default)";
Points.Items.Clear();
Points.Items.AddRange(ReadPoints.ToArray());
Points.SelectedIndex = 0;
}

}
}