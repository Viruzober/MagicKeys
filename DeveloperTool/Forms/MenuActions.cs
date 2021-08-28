using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperTool
{

public partial class DevMenu : Form
{

public void Exit(object sender, EventArgs e)
{
DeveloperTool.LockDeveloperTool = true;
Ni.Visible = false;
DialogResult result = MessageBox.Show("Do you really want to exit DeveloperTool?", "Exit DeveloperTool", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
if (result == DialogResult.OK)
{
MKLib.Speak("Goodbye");
Application.Exit();
return;
}
DeveloperTool.LockDeveloperTool = false;
Ni.Visible = true;
}

}
}