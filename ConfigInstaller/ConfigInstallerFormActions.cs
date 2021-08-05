using System;
using System.IO;
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

public void Ins_Click(object sender, EventArgs e)
{
Ins.Enabled = false;
LB.Enabled = false;
TB.Text = "";
foreach(var Item in LB.CheckedItems)
{
TB.Text += "Installing "+Item.ToString()+"\r\n";
if(File.Exists("./Settings/"+Item.ToString()+"/Install.reg"))
{
TB.Text += "Import Install.reg - "+ConfigInstaller.RegImport(Item.ToString())+"\r\n";
}
if(File.Exists("./Settings/"+Item.ToString()+"/Files.copy"))
{
string[] FileStr = File.ReadAllLines(@"./Settings/"+Item.ToString()+"/Files.copy");
foreach(string FC in FileStr)
{
string[] Copy = FC.Split(",");
TB.Text += "Copying "+Copy[0]+" to "+Copy[1]+" "+ConfigInstaller.CopyFiles(Copy[0], Copy[1])+"\r\n";
}
}
}
LB.Enabled = true;
Ins.Enabled = true;
}

}
}