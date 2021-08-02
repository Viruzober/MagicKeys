using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace ConfigInstaller
{
public partial class ConfigInstaller
{
[STAThread]
static void Main()
{
Directory.SetCurrentDirectory(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName));
DialogResult DPI = MessageBox.Show(
T._("For MagicKeys to work correctly, you need to set the screen scale to 100%. When you click on the \"yes\" button, this will be done automatically."),
T._("Attention"),
MessageBoxButtons.YesNo,
MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1);
if (DPI == DialogResult.OK)
{
ChangeDPI(-1);
}
DialogResult SSize = MessageBox.Show(
T._("Also, for the MagicKeys to work properly, you need to set the maximum display resolution. Click \"Yes\" to automatically apply the parameter."),
T._("Attention"),
MessageBoxButtons.YesNo,
MessageBoxIcon.Information,
MessageBoxDefaultButton.Button1);
if (SSize == DialogResult.OK)
{
int[] DS = GetMaxScreenSize();
SetResolution(DS[0], DS[1]);
}
Application.Run(new ConfigInstallerForm());
}
}
}