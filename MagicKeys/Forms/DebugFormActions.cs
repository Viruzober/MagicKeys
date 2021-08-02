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
MagicKeys.SoundPlay("Error", 0);
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
case "FileNotFound":
FileNotFoundError(DI);
break;
case "VUILoader":
VUILoaderError(DI);
break;
case "ExceptionHook":
ExceptionHookError(DI);
break;
}
}
public void Exit_Click(Object Sender, EventArgs e)
{
MagicKeys.KeySwitch = 1;
MagicKeys.HM.Ni.Visible = false;
Environment.Exit(1);
}
public void IniReadError(string[] EX)
{
DebugText.Text =
T._("Message:")+" "+EX[5]+"\r\n"+
T._("File:")+" "+EX[2]+"\r\n"+
T._("Line:")+" "+EX[1]+"\r\n"+
T._("Section:")+" "+EX[3]+"\r\n"+
T._("Key:")+" "+EX[4];
}
public void IniReadKeysError(string[] EX)
{
DebugText.Text =
T._("Message:")+" "+EX[4]+"\r\n"+
T._("File:")+" "+EX[2]+"\r\n"+
T._("Line:")+" "+EX[1]+"\r\n"+
T._("Section:")+" "+EX[3];
}
public void KeyRegError(string[] EX)
{
DebugText.Text =
T._("Message:")+" "+T._("The keyboard shortcut cannot be registered")+"\r\n"+
T._("File:")+" "+EX[1]+"\r\n"+
T._("Key:")+" "+EX[2];
}
public void FileNotFoundError(string[] EX)
{
DebugText.Text =
T._("Message:")+" "+T._("File not found")+"\r\n"+
T._("File:")+" "+EX[1];
}
public void VUILoaderError(string[] EX)
{
DebugText.Text =
T._("Message:")+" "+T._("The key or value doesn't exist.")+"\r\n"+
T._("File:")+" "+EX[1]+"\r\n"+
T._("Object:")+" "+EX[2]+"\r\n";
}
public void ExceptionHookError(string[] EX)
{
DebugText.Text = EX[1];
}
}
}