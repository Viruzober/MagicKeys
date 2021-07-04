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
Application.Run(new ConfigInstallerForm());
}

}
}