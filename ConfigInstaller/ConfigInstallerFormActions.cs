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
string[] Dir = Directory.GetDirectories("./Settings");
foreach(string d in Dir)
{
LB.Items.Add(Path.GetFileName(d));
}
}

}
}