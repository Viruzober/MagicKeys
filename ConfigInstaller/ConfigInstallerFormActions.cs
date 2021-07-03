using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ConfigInstaller
{
public partial class ConfigInstallerForm : Form
{

public void FormLoad(object sender, EventArgs e)
{
Directory.CreateDirectory("./Settings");
Directory.CreateDirectory("./Settings/123");
Directory.CreateDirectory("./Settings/234");
string[] Dir = Directory.GetDirectories("./Settings");
foreach(string d in Dir)
{
LB.Items.Add(Path.GetFileName(d));
}
}

}
}