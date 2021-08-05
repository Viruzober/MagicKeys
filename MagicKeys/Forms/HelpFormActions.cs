using System;
using System.IO;
using System.Windows.Forms;

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