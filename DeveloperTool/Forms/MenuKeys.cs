using System;
using System.Windows.Forms;
using System.IO;

namespace MagicKeys
{
public partial class DevMenu : Form
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
DeveloperTool.OptionKeyUnReg();
Ni.Text = "Developer tool is disabled";
MagicKeys.Speak("Developer tool is disabled");
DeveloperTool.KeySwitch = 1;
DeveloperTool.OptionKeyReg();
}
else if (DeveloperTool.KeySwitch == 1)
{
Ni.Text = "Developer tool is enabled";
MagicKeys.Speak("Developer tool is enabled");
DeveloperTool.KeySwitch = 0;
DeveloperTool.OptionKeyReg();
}
}
else if (modifier == (MKC.CTRL|MKC.ALT) & key == Keys.A)
{
if (DeveloperTool.AutoOCR == 1)
{
MagicKeys.Speak("Auto OCR is disabled");
DeveloperTool.AutoOCR = 0;
}
else if (DeveloperTool.AutoOCR == 0)
{
MagicKeys.Speak("Auto OCR is enabled");
DeveloperTool.AutoOCR = 1;
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
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F4)
{
DeveloperTool.SpeakModule();
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
else if (modifier == (MKC.SHIFT) & key == Keys.O)
{
DeveloperTool.VisionBot();
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.Z)
{
DeveloperTool.OCRZoomChange();
}
else if (modifier == (MKC.CTRL) & key == Keys.Oemplus)
{
DeveloperTool.OCRClick("Right");
}
else if (modifier == (MKC.CTRL) & key == Keys.OemMinus)
{
DeveloperTool.OCRClick("Left");
}
else if (key == Keys.OemMinus)
{
int[] MP = MagicKeys.GetMousePosition();
MagicKeys.MouseClick("Left", MP[0], MP[1], 1, 0, 0, 10);
MagicKeys.Speak("Left click");
}
else if (key == Keys.Oemplus)
{
int[] MP = MagicKeys.GetMousePosition();
MagicKeys.MouseClick("Right", MP[0], MP[1], 1, 0, 0, 10);
MagicKeys.Speak("Right click");
}
else if (key == Keys.M)
{
DeveloperTool.SpeakMousePosition();
}
else if (key == Keys.C)
{
DeveloperTool.SpeakColor();
}
else if (modifier == (MKC.CTRL) & key == Keys.S)
{
DeveloperTool.Save();
}
else if (modifier == (MKC.CTRL) & key == Keys.I)
{
DeveloperTool.ImgSave();
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.G)
{
DeveloperTool.MouseGoTo();
}
else if (key == Keys.R)
{
DeveloperTool.SpeakWindowRect();
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.O)
{
DeveloperTool.OCRWordPosition();
}
else if (key == Keys.W)
{
DeveloperTool.SpeakWindowInfo();
}
break;
}
base.WndProc(ref m);
}

}
}