using System;
using System.IO;
using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void DeleteCurrentProject()
{
if (ProjectName != string.Empty)
{
KeyUnReg();
DialogResult result = MessageBox.Show(T._("Do you really want to delete current project?"), T._("Delete current project"), MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
if (result == DialogResult.OK)
{
Directory.Delete(@"Projects\"+ProjectName, true);
ProjectName = string.Empty;
}
KeyReg();
}
}

}
}