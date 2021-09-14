using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using static MKLib;
using System.IO;

namespace DeveloperTool
{
public partial class VUFManagerForm: Form
{

public void Form_Show(Object Sender, EventArgs e)
{
this.Activate();
GetAllVUF();
GetAllFunctions();
}

public void GetAllVUF()
{
VUF.Items.Clear();
List<string> AllVUF = Directory.GetFiles(API.GetVUIPath()).Where(v => v.Contains(".vuf")).Select(t => Path.GetFileNameWithoutExtension(t)).ToList();
if (AllVUF.Any() == true)
{
AllVUF[AllVUF.IndexOf(DeveloperTool.VUIName)] = AllVUF[AllVUF.IndexOf(DeveloperTool.VUIName)]+" (Default)";
VUF.Items.AddRange(AllVUF.ToArray());
VUF.SelectedIndex = 0;
GetAllFunctions();
return;
}
DeleteVUF.Enabled = false;
RenameVUF.Enabled = false;
}

public void ChangeSelectVUF(object Sender, EventArgs e)
{
GetAllFunctions();
if (VUF.SelectedItem.ToString() == DeveloperTool.VUIName+" (Default)")
{
RenameVUF.Enabled = false;
DeleteVUF.Enabled = false;
return;
}
RenameVUF.Enabled = true;
DeleteVUF.Enabled = true;
}

public async void Add_VUF(Object Sender, EventArgs e)
{
string AddNewVUF = InputTextBox(T._("VUF Name"), T._("Enter new VUF name."));
if (AddNewVUF == null) return;
if (File.Exists(API.GetVUIPath()+"/"+AddNewVUF+".vuf") == true)
{
MessageBox.Show(T._("An VUF with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
CreateFile(API.GetVUIPath()+"/"+AddNewVUF+".vuf");
GetAllVUF();
}

public async void Delete_VUF(object Sender, EventArgs e)
{
DialogResult result = await Task.Run(() => MessageBox.Show(T._("Do you really want to delete the selected VUF?"), T._("Delete VUF"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification));
if (result == DialogResult.OK)
{
File.Delete(API.GetVUIPath()+"/"+VUF.SelectedItem.ToString()+".vuf");
}
GetAllVUF();
}

public void Rename_VUF(Object Sender, EventArgs e)
{
string NewVUFName = InputTextBox(T._("VUF Name"), T._("Enter new VUF name."));
if (NewVUFName == null) return;
if (File.Exists(API.GetVUIPath()+"/"+NewVUFName+".vui") == true)
{
MessageBox.Show(T._("An VUF with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
File.Move(API.GetVUIPath()+"/"+VUF.SelectedItem.ToString()+".vuf", API.GetVUIPath()+"/"+NewVUFName+".vuf");
GetAllVUF();
}

public void GetAllFunctions()
{
FunctionsList.Items.Clear();
List<string> AllFunctions = Ini.IniReadSections(API.GetVUIPath() + "/" + VUF.SelectedItem.ToString().Split(" (Default)")[0] + ".vuf").Where(o => o != "Params" || o != "Keys").ToList();
if (AllFunctions.Any() == true)
{
FunctionsList.Items.AddRange(AllFunctions.ToArray());
FunctionsList.SelectedIndex = 0;
RenameFunction.Enabled = true;
EditFunction.Enabled = true;
DeleteFunction.Enabled = true;
return;
}
EditFunction.Enabled = false;
RenameFunction.Enabled = false;
DeleteFunction.Enabled = false;
}

public void Add_Function(object Sender, EventArgs e)
{
string AddFunctionName = InputTextBox(T._("VUF object Name"), T._("Enter new VUF object name."));
if (AddFunctionName== null) return;
        if (Ini.IniSectionExists(API.GetVUIPath() + "/" + VUF.SelectedItem.ToString().Split(" (Default)")[0] + ".vuf", AddFunctionName) == true)
        {
MessageBox.Show(T._("An function with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
Ini.IniAddSection(API.GetVUIPath() + "/" + VUF.SelectedItem.ToString().Split(" (Default)")[0] + ".vuf", AddFunctionName);
GetAllFunctions();
        }

public void Edit_Function(object Sender, EventArgs e)
{
ObjectEditorForm OEF = new ObjectEditorForm(VUF.SelectedItem.ToString().Split(" (Default)")[0], FunctionsList.SelectedItem.ToString());
OEF.ShowDialog();
}

        public void Rename_Function(object Sender, EventArgs e)
{
string NewFunctionName = InputTextBox(T._("VUF object Name"), T._("Enter new function name."));
if (NewFunctionName== null) return;
        if (Ini.IniSectionExists(API.GetVUIPath() + "/" + VUF.SelectedItem.ToString().Split(" (Default)")[0] + ".vuf", NewFunctionName) == true)
        {
MessageBox.Show(T._("An function with the same name already exists."), T._("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
return;
}
Ini.IniRenameSection(API.GetVUIPath() + "/" + VUF.SelectedItem.ToString().Split(" (Default)")[0] + ".vuf", FunctionsList.SelectedItem.ToString(), NewFunctionName);
GetAllFunctions();
}

public async void Delete_Function(object Sender, EventArgs e)
{
DialogResult result = await Task.Run(() => MessageBox.Show(T._("Do you really want to delete the selected function?"), T._("Delete function"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification));
if (result == DialogResult.OK)
{
Ini.IniDeleteSection(API.GetVUIPath() + "/" + VUF.SelectedItem.ToString().Split(" (Default)")[0]+".vuf", FunctionsList.SelectedItem.ToString());
GetAllFunctions();
}
}

}
}