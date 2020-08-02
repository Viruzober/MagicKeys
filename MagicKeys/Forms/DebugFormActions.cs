using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace MagicKeys
{
public partial class DebugForm : Form
{

public void DebugForm_Shown(object sender, EventArgs e)
{
this.Activate();
string[] DI = DebugInfo.Split("|");
switch(DI[0])
{
case "IniRead":
IniReadError();
break;
}
}

public void DebugText_KeyDown(Object Sender, KeyEventArgs e)
{
if (e.KeyCode == Keys.Escape)
{
this.Close();
}
}

public void IniReadError()
{
DebugText.Text = "Error";
}

}
}