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
Application.Run(new ConfigInstallerForm());
}

}
}