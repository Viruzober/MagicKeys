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
IniReadError(DI);
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

public void IniReadError(string[] EX)
{
DebugText.Text =
"Error in file: "+EX[2]+" on line "+EX[1]+"\r\n"+
"section "+EX[3]+" key "+EX[4]+".";
}

}
}