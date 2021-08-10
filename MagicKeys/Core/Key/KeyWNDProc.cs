using System.Collections.Generic;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public class KeyWNDProc : Form
{
protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
string Key = KeyParse((int)m.LParam & 0xFFFF)+GetKeyName(((int)m.LParam >> 16) & 0xFFFF);
if (VUIKeys.ContainsKey(Key) == true)
{
(string Func, string Param) = FuncParse(VUIKeys[Key]);
if(VUIKeys[Key].Split(",", 2)[0] == "Background")
{
if (Func == ThreadFunc.Split(",")[0])
{
ThreadFunc = string.Empty;
break;
}
var BFObj = new BackgroundFuncObject(Func, Param);
BackgroundInvoke(BFObj);
break;
}
else
{
Invoker(Func, Param);
break;
}
}
if (Key == "Ctrl+Shift+F3")
{
MagicKeys.HelpForm();
}
else if (Key == "Ctrl+Shift+F5")
{
VUILoader(API.GetVUI());
}
else if (Key == "Shift+Tab" || Key == "Left")
{
MagicKeys.VUIObjectNavigator("Back");
}
else if (Key == "Tab" || Key == "Right")
{
MagicKeys.VUIObjectNavigator("Next");
}
else if (Key == "F1")
{
MagicKeys.Speak(API.GetHelp());
}
else if (Key == "Enter")
{
MagicKeys.Invoker(API.GetFunc("Func"), API.GetParam("Func"));
}
break;
}
base.WndProc(ref m);
}

}
}