using System;
using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{
public partial class ControlSearchForm : Form
{

public void Form_Show(object Sender, EventArgs e)
{
this.Activate();
}

public void OK_Click(object Sender, EventArgs e)
{
this.DialogResult = DialogResult.OK;
this.Close();
}

public void Cancel_Click(object Sender, EventArgs e)
{
this.DialogResult = DialogResult.Cancel;
this.Close();
}

public void ModulesList_ChangeSelectItem(object Sender, EventArgs e)
{
EnterModuleName.Text = ModulesList.SelectedItem.ToString();
}

public string GetString()
{
return EnterModuleName.Text;
}

}
}