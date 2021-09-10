using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using static MKLib;
using System.Threading.Tasks;
namespace DeveloperTool
{
public partial class PointEditorForm : Form
{

public void Form_Show(object Sender, EventArgs e)
{
this.Activate();
}

public async void Save_Click(object Sender, EventArgs e)
{
if (string.IsNullOrEmpty(PointName.Text) == true || string.IsNullOrEmpty(Modules.Text) == true)
{
await Task.Run(() => MessageBox.Show(T._("Some fields are empty."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error));
return;
}
Ini.IniRenameSection("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", OldPointName, PointName.Text);
Ini.IniWrite("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", PointName.Text, "VUI", VUI.SelectedItem.ToString());
Ini.IniWrite("Projects/"+DeveloperTool.ProjectName+"/Manifest.ini", PointName.Text, "Module", Modules.Text);
this.Close();
}

public void Cancel_Click(object Sender, EventArgs e)
{
this.Close();
}

}
}