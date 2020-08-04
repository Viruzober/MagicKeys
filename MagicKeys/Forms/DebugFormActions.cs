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
MagicKeys.SoundPlay("Error.ogg", 0);
this.Activate();
string[] DI = DebugInfo.Split("|");
switch(DI[0])
{
case "IniRead":
IniReadError(DI);
break;
case "IniReadKeys":
IniReadKeysError(DI);
break;
case "KeyReg":
KeyRegError(DI);
break;
case "GetPluginType":
GetPluginTypeError(DI);
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

public void Exit_Click(Object Sender, EventArgs e)
{
MagicKeys.KeySwitch = 1;
MagicKeys.HM.Ni.Visible = false;
Application.Exit();
}

public void IniReadError(string[] EX)
{
DebugText.Text =
"File: "+EX[2]+"\r\n"+
"Line: "+EX[1]+"\r\n"+
"Section: "+EX[3]+"\r\n"+
"Key: "+EX[4]+"\r\n"+
"Message: "+EX[5];
}

public void IniReadKeysError(string[] EX)
{
DebugText.Text =
"Message: "+EX[4]+"\r\n"+
"File: "+EX[2]+"\r\n"+
"Line: "+EX[1]+"\r\n"+
"Section: "+EX[3];
}

public void KeyRegError(string[] EX)
{
DebugText.Text =
"Message: the keyboard shortcut cannot be registered\r\n"+
"File: "+EX[1]+"\r\n"+
"Key: "+EX[2];
}


public void GetPluginTypeError(string[] EX)
{
DebugText.Text =
"Message: File not found\r\n"+
"File: "+EX[1]+"\r\n"+
"Module: "+EX[2];
}

}
}