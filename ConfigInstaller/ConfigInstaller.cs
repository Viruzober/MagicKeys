using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ConfigInstaller
{
public partial class ConfigInstaller
{

[STAThread]
static void Main()
{
ChangeDPI(-1);
int[] DS = GetMaxScreenSize();
SetResolution(DS[0], DS[1]);
Application.Run(new ConfigInstallerForm());
}

}
}