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
Stream HelpFileStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"MagicKeys."+HelpFile.Substring(0, HelpFile.Length - 3)+"help");
StreamReader HelpStreamReader = new StreamReader(HelpFileStream);
string FileStr = HelpStreamReader.ReadToEnd().ToString();
HelpText.Text = FileStr;
}

}
}