using System.Windows.Forms;
using static MKLib;

namespace DeveloperTool
{

public partial class DevMenu : Form
{
protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
string Key = GetModKeyName((int)m.LParam & 0xFFFF)+GetKeyName(((int)m.LParam >> 16) & 0xFFFF);
if (Key == "Ctrl+Shift+F1")
{
if (DeveloperTool.LockDeveloperTool == false)
{
Ni.Text = "Developer tool is disabled";
MKLib.Speak("Developer tool is disabled");
DeveloperTool.LockDeveloperTool = true;;
}
else if (DeveloperTool.LockDeveloperTool == true)
{
Ni.Text = "Developer tool is enabled";
MKLib.Speak("Developer tool is enabled");
DeveloperTool.LockDeveloperTool = false;
}
}
else if (Key == "Ctrl+Shift+F2")
{
Exit(null, null);
}
else if (Key == "Ctrl+Shift+F3")
{
DeveloperTool.ControlSearch();
}
else if (Key == "Ctrl+Shift+F4")
{
DeveloperTool.SpeakModule();
}
break;
}
base.WndProc(ref m);
}

}
}