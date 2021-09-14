using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using static MKLib;
using System.Threading.Tasks;
namespace DeveloperTool
{
public partial class ObjectEditorForm : Form
{

public void Form_Show(object Sender, EventArgs e)
{
this.Activate();
if (Ini.IniReadKeys(Path.Combine(API.GetVUIPath(), VUIName+".vui"), ObjectName).Any() == true)
{
ObjectText.Text = Ini.IniRead(Path.Combine(API.GetVUIPath(), VUIName+".vui"), ObjectName, "Text");
ObjectHelp.Text = Ini.IniRead(Path.Combine(API.GetVUIPath(), VUIName+".vui"), ObjectName, "Help");
ObjectFuncs.Items.AddRange(Ini.IniReadSections(Path.Combine(API.GetVUIPath(), VUIName+".vuf")).ToArray());
ObjectFuncs.SelectedIndex = 0;
}
}

public async void Save_Click(object Sender, EventArgs e)
{
if (string.IsNullOrEmpty(ObjectText.Text) == true || string.IsNullOrEmpty(ObjectHelp.Text) == true)
{
await Task.Run(() => MessageBox.Show(T._("Some fields are empty."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error));
return;
}
Ini.IniWrite(Path.Combine(API.GetVUIPath(), VUIName+".vui"), ObjectName, "Text", ObjectText.Text);
Ini.IniWrite(Path.Combine(API.GetVUIPath(), VUIName+".vui"), ObjectName, "Help", ObjectHelp.Text);
Ini.IniWrite(Path.Combine(API.GetVUIPath(), VUIName+".vui"), ObjectName, "Func", ObjectFuncs.SelectedItem.ToString());
this.Close();
}

public void Cancel_Click(object Sender, EventArgs e)
{
this.Close();
}

}
}