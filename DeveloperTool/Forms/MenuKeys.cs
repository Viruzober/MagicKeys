using System;
using System.Windows.Forms;
using System.IO;

namespace MagicKeys
{
public partial class Menu : Form
{

protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
int modifier = (int)m.LParam & 0xFFFF;
Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F1)
{
if (DeveloperTool.KeySwitch == 0)
{
DeveloperTool.KeyUnReg();
Ni.Text = "Developer tool is disabled";
MagicKeys.Speak("Developer tool is disabled");
DeveloperTool.KeySwitch = 1;
}
else if (DeveloperTool.KeySwitch == 1)
{
Ni.Text = "Developer tool is enabled";
MagicKeys.Speak("Developer tool is enabled");
DeveloperTool.KeySwitch = 0;
}
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F2)
{
Exit(null, null);
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F3)
{
DeveloperTool.ControlSearch();
}
else if (key == Keys.Left)
{
DeveloperTool.MouseMover("Left");
}
else if (key == Keys.Right)
{
DeveloperTool.MouseMover("Right");
}
else if (key == Keys.Up)
{
DeveloperTool.MouseMover("Up");
}
else if (key == Keys.Down)
{
DeveloperTool.MouseMover("Down");
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.P)
{
DeveloperTool.MouseStepChange();
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.R)
{
DeveloperTool.RectOCR();
}
else if (modifier == (MKC.CTRL) & key == Keys.O)
{
DeveloperTool.WindowsOCR();
}
break;
}
base.WndProc(ref m);
}

}
}