using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MagicKeys
{
public partial class DeveloperTool
{
public static async void ControlSearch()
{
KeyUnReg();
OptionKeyUnReg();
InputTextBox ITB = new InputTextBox();
ITB.Text = T._("Control search");
ITB.InputBoxLabel.Text = T._("Enter substring to search for a module.");
ITB.Value.Text = Module;
await Task.Run(() => ITB.ShowDialog());
string ModuleName = string.Empty;
if (ITB.DialogResult == DialogResult.OK)
{
ModuleName = ITB.GetString();
}
if (ModuleName == string.Empty)
{
OptionKeyReg();
return;
}
Module = ModuleName;
P = GetPluginCoord();
if (P[0] == 1)
{
MagicKeys.Speak("Module found");
KeyReg();
OptionKeyReg();
MagicKeys.SoundPlay("WindowOpened", 0);
Directory.CreateDirectory(@".\DevSave\"+Module);
ModuleFound();
KeyUnReg();
MagicKeys.SoundPlay("WindowClosed", 0);
}
else
{
MagicKeys.Speak("Not found");
OptionKeyReg();
}
}
}
}