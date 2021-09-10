using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using static MKLib;
using System.IO;

namespace DeveloperTool
{
public partial class VUIManagerForm : Form
{

public void Form_Show(Object Sender, EventArgs e)
{
this.Activate();
GetAllVUI();
GetAllObjects();
}

public void GetAllVUI()
{
VUI.Items.Clear();
List<string> AllVUI = Directory.GetFiles(API.GetVUIPath()).Where(v => v.Contains(".vui")).Select(t => Path.GetFileNameWithoutExtension(t)).ToList();
if (AllVUI.Any() == true)
{
AllVUI[AllVUI.IndexOf(DeveloperTool.VUIName)] = AllVUI[AllVUI.IndexOf(DeveloperTool.VUIName)]+" (Default)";
VUI.Items.AddRange(AllVUI.ToArray());
VUI.SelectedIndex = 0;
GetAllObjects();
return;
}
DeleteVUI.Enabled = false;
RenameVUI.Enabled = false;
}

public void ChangeSelectVUI(object Sender, EventArgs e)
{
GetAllObjects();
if (VUI.SelectedItem.ToString() == DeveloperTool.VUIName+" (Default)")
{
RenameVUI.Enabled = false;
DeleteVUI.Enabled = false;
return;
}
RenameVUI.Enabled = true;
DeleteVUI.Enabled = true;
}

public void Add_VUI(Object Sender, EventArgs e)
{
string AddNewVUI = InputTextBox(T._("VUI Name"), T._("Enter new VUI name."));
if (AddNewVUI == null) return;
if (File.Exists(API.GetVUIPath()+"/"+AddNewVUI+".vui") == true)
{
MessageBox.Show(T._("An VUI with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
CreateFile(API.GetVUIPath()+"/"+AddNewVUI+".vui");
CreateFile(API.GetVUIPath()+"/"+AddNewVUI+".vuf");
GetAllVUI();
}

public async void Delete_VUI(object Sender, EventArgs e)
{
DialogResult result = await Task.Run(() => MessageBox.Show(T._("Do you really want to delete the selected VUI?"), T._("Delete VUI"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification));
if (result == DialogResult.OK)
{
File.Delete(API.GetVUIPath()+"/"+VUI.SelectedItem.ToString()+".vui");
GetAllVUI();
}
}

public void Rename_VUI(Object Sender, EventArgs e)
{
string NewVUIName = InputTextBox(T._("VUI Name"), T._("Enter new VUI name."));
if (NewVUIName == null) return;
if (File.Exists(API.GetVUIPath()+"/"+NewVUIName+".vui") == true)
{
MessageBox.Show(T._("An VUI with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
File.Move(API.GetVUIPath()+"/"+VUI.SelectedItem.ToString()+".vui", API.GetVUIPath()+"/"+NewVUIName+".vui");
File.Move(API.GetVUIPath()+"/"+VUI.SelectedItem.ToString()+".vuf", API.GetVUIPath()+"/"+NewVUIName+".vuf");
GetAllVUI();
}

public void GetAllObjects()
{
VUIObjects.Items.Clear();
List<string> AllObjects = Ini.IniReadSections(API.GetVUIPath() + "/" + VUI.SelectedItem.ToString().Split(" (Default)")[0] + ".vui").Where(o => o != "Params" || o != "Keys").ToList();
if (AllObjects.Any() == true)
{
VUIObjects.Items.AddRange(AllObjects.ToArray());
VUIObjects.SelectedIndex = 0;
RenameObject.Enabled = true;
DeleteObject.Enabled = true;
return;
}
RenameObject.Enabled = false;
DeleteObject.Enabled = false;
}

public void Add_Object(object Sender, EventArgs e)
{
string AddVUIObjectName = InputTextBox(T._("VUI object Name"), T._("Enter new VUI object name."));
if (AddVUIObjectName== null) return;
        if (Ini.IniSectionExists(API.GetVUIPath() + "/" + VUI.SelectedItem.ToString().Split(" (Default)")[0] + ".vui", AddVUIObjectName) == true)
        {
MessageBox.Show(T._("An Object with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
Ini.IniAddSection(API.GetVUIPath() + "/" + VUI.SelectedItem.ToString().Split(" (Default)")[0] + ".vui", AddVUIObjectName);
GetAllObjects();
        }

        public void Rename_Object(object Sender, EventArgs e)
{
string AddVUIObjectName = InputTextBox(T._("VUI object Name"), T._("Enter new VUI object name."));
if (AddVUIObjectName== null) return;
        if (Ini.IniSectionExists(API.GetVUIPath() + "/" + VUI.SelectedItem.ToString().Split(" (Default)")[0] + ".vui", AddVUIObjectName) == true)
        {
MessageBox.Show(T._("An Object with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
Ini.IniRenameSection(API.GetVUIPath() + "/" + VUI.SelectedItem.ToString().Split(" (Default)")[0] + ".vui", VUIObjects.SelectedItem.ToString(), AddVUIObjectName);
GetAllObjects();
}

public async void Delete_Object(object Sender, EventArgs e)
{
DialogResult result = await Task.Run(() => MessageBox.Show(T._("Do you really want to delete the selected VUI object?"), T._("Delete VUI object"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification));
if (result == DialogResult.OK)
{
Ini.IniDeleteSection(API.GetVUIPath() + "/" + VUI.SelectedItem.ToString().Split(" (Default)")[0]+".vui", VUIObjects.SelectedItem.ToString());
GetAllObjects();
}
}

}
}