using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MagicKeys
{
public partial class HelpForm : Form
{

public void HelpForm_Shown(object sender, EventArgs e)
{
this.Activate();
StreamReader HelpStreamReader = new StreamReader(HelpFile);
string FileStr = HelpStreamReader.ReadToEnd().ToString();
HelpText.Text = FileStr;
}

public void HelpForm_KeyDown(Object Sender, KeyEventArgs e)
{
if (e.KeyCode == Keys.Escape)
{
this.Close();
}
}

}
}