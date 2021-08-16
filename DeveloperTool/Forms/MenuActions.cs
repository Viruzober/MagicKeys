using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class DevMenu : Form
{

public async void Exit(object sender, EventArgs e)
{
DeveloperTool.KeySwitch = 1;
DeveloperTool.OptionKeyUnReg();
Ni.Visible = false;
DialogResult result = await Task.Run(()=> MessageBox.Show("Do you really want to exit DeveloperTool?", "Exit DeveloperTool", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification));
if (result == DialogResult.OK)
{
MKLib.Speak("Goodbye");
Application.Exit();
return;
}
DeveloperTool.KeySwitch = 0;
Ni.Visible = true;
DeveloperTool.OptionKeyReg();
}

}
}