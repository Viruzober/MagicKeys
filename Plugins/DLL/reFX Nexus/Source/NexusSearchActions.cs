using System;
using System.IO;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class NexusSearchForm
{
public void NexusSearchForm_Shown(object sender, EventArgs e)
{
this.Activate();
string ScanDir = MagicKeys.RegReader(Microsoft.Win32.Registry.CurrentUser, "SOFTWARE/reFX/Nexus", "ContentPath");
string[] Dirs = Directory.GetDirectories(ScanDir+"/Presets");
foreach (string S in Dirs)
{
ListBank.Items.Add(Path.GetFileName(S));
}
ListBank.Items[0].Selected = true;
}

public void ListBank_SelectedIndexChanged(object sender, EventArgs e)
{
try
{
ListPatch.Items.Clear();
string ScanDir = MagicKeys.RegReader(Microsoft.Win32.Registry.CurrentUser, "SOFTWARE/reFX/Nexus", "ContentPath");
string[] Files = Directory.GetFiles(ScanDir+"/Presets/"+(ListBank.FocusedItem.Text));
foreach (string S in Files)
{
ListPatch.Items.Add(Path.GetFileNameWithoutExtension(Path.GetFileName(S)));
}
ListPatch.Items[0].Selected = true;
}
catch(Exception)
{
}
}

public void SearchText_KeyDown(object sender, KeyEventArgs e)
{
if (e.KeyCode == Keys.Enter)
{
ListPatch.Items.Clear();
string ScanDir = MagicKeys.RegReader(Microsoft.Win32.Registry.CurrentUser, "SOFTWARE/reFX/Nexus", "ContentPath");
string[] Dirs = Directory.GetDirectories(ScanDir+"/Presets");
if (SearchText.Text != "")
{
foreach (string Bank in Dirs)
{
string[] Files = Directory.GetFiles(Bank);
foreach (string Patch in Files)
{
if ((Patch.ToLower()).Contains(SearchText.Text.ToLower()))
{
ListPatch.Items.Add(Path.GetFileNameWithoutExtension(Path.GetFileName(Patch)));
}
}
}
}
}
}

public void ListPatch_SelectedIndexChanged(object sender, EventArgs e)
{
if (ListPatch.FocusedItem != null)
{
OK.Enabled = true;
}
else
{
OK.Enabled = false;
}
}

public void ButtonOK_Click(object sender, EventArgs e)
{
this.DialogResult = DialogResult.OK;
this.Close();
Result = ListPatch.FocusedItem.Text;
}

public void ButtonCancel_Click(object sender, EventArgs e)
{
this.Close();
}

public string GetString()
{
return Result;
}

}
}