using System.Windows.Forms;
using System.Threading;
using static MKLib;

namespace DeveloperTool
{

public partial class KeyWNDProc : Form
{
protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
string Key = GetModKeyName((int)m.LParam & 0xFFFF)+GetKeyName(((int)m.LParam >> 16) & 0xFFFF);
if (Key == "Ctrl+Shift+E")
{
DeveloperTool.EditProject();
}
else if (Key == "Ctrl+D")
{
DeveloperTool.DeleteCurrentProject();
}
else if (Key == "Ctrl+Shift+N")
{
DeveloperTool.CreateProject();
}
else if (Key== "Ctrl+K")
{
DeveloperTool.LockDevKeys();
}
else if (Key== "Ctrl+A")
{
if (DeveloperTool.AutoOCR == true)
{
MKLib.Speak("Auto OCR is disabled");
DeveloperTool.AutoOCR = false;
}
else if (DeveloperTool.AutoOCR == false)
{
MKLib.Speak("Auto OCR is enabled");
DeveloperTool.AutoOCR = true;
}
}
else if (Key == "Left" || Key == "Right" || Key == "Up" || Key == "Down")
{
DeveloperTool.MouseMover(Key);
}
else if (Key == "Ctrl+S")
{
DeveloperTool.MouseStepChange();
}
else if (Key == "Ctrl+R")
{
DeveloperTool.RectOCR();
}
else if (Key == "Ctrl+O")
{
DeveloperTool.WindowsOCR();
}
else if (Key == "Shift+O")
{
DeveloperTool.VisionBot();
}
else if (Key == "Ctrl+Z")
{
DeveloperTool.OCRZoomChange();
}
else if (Key == "Ctrl++")
{
DeveloperTool.OCRClick("Right");
}
else if (Key == "Ctrl+-")
{
DeveloperTool.OCRClick("Left");
}
else if (Key == "-")
{
int[] MP = MKLib.GetMousePosition();
MKLib.MouseClick("Left", MP[0], MP[1], 1, 0, 0, 10);
MKLib.Speak("Left click");
}
else if (Key == "+")
{
int[] MP = MKLib.GetMousePosition();
MKLib.MouseClick("Right", MP[0], MP[1], 1, 0, 0, 10);
MKLib.Speak("Right click");
}
else if (Key == "M")
{
DeveloperTool.SpeakMousePosition();
}
else if (Key == "C")
{
DeveloperTool.SpeakColor();
}
else if (Key == "Ctrl+I")
{
DeveloperTool.ImgSave();
}
else if (Key == "Ctrl+G")
{
DeveloperTool.MouseGoTo();
}
else if (Key == "R")
{
DeveloperTool.SpeakWindowRect();
}
else if (Key == "Ctrl+Shift+O")
{
DeveloperTool.OCRWordPosition();
}
else if (Key == "Ctrl+W")
{
DeveloperTool.SpeakControlInfo();
}
else if (Key == "W")
{
DeveloperTool.SpeakWindowInfo();
}
break;
}
base.WndProc(ref m);
}

}
}