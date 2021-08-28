using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MKLib;
namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void ControlSearch()
{
InputTextBox ITB = new InputTextBox();
ITB.Text = T._("Control search");
ITB.InputBoxLabel.Text = T._("Enter substring to search for a module.");
ITB.Value.Text = ModuleName;
ITB.ShowDialog();
if (ITB.DialogResult == DialogResult.OK)
{
if(GetModuleCoords(ITB.GetString()) == new ModuleCoords())
{
Speak("Not found", true);
ModuleName = string.Empty;
return;
}
ModuleName = ITB.GetString();
}
}

}
}