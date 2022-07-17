using System.Collections.Generic;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
using static MKLib;
using System.Linq;

namespace MagicKeys
{

public class KeyWNDProc : Form
{
protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
string ReplaceWNDProcKey = GetKeyMod((int)m.LParam & 0xFFFF)+GetKeyName(((int)m.LParam >> 16) & 0xFFFF);
if (VUIKeysFunctions.Where(k => k.Key == ReplaceWNDProcKey).Any() == true)
{
VUIKeyFuncContainer keyFunc = VUIKeysFunctions.Where(k => k.Key == ReplaceWNDProcKey).ToArray()[0];
if(keyFunc.Function.Background == true)
{
if (keyFunc.Function.Name == ThreadFunc.Split(",")[0])
{
ThreadFunc = string.Empty;
break;
}
var BFObj = new BackgroundFuncObject(keyFunc.Function.Name, keyFunc.Function.Param);
BackgroundInvoke(BFObj);
break;
}
else
{
Invoker(keyFunc.Function.Name, keyFunc.Function.Param);
break;
}
}
if (ReplaceWNDProcKey == "Ctrl+Shift+F3")
{
MagicKeys.HelpForm();
}
else if (ReplaceWNDProcKey == "Ctrl+Shift+F5")
{
VUILoader(API.GetVUI());
}
else if (ReplaceWNDProcKey == "Shift+Tab" || ReplaceWNDProcKey == "Left")
{
MagicKeys.VUIObjectNavigator("Back");
}
else if (ReplaceWNDProcKey == "Tab" || ReplaceWNDProcKey == "Right")
{
MagicKeys.VUIObjectNavigator("Next");
}
else if (ReplaceWNDProcKey == "F1")
{
MKLib.Speak(API.GetHelp());
}
else if (ReplaceWNDProcKey == "Enter")
{
MagicKeys.Invoker(API.GetFunc("Func"), API.GetParam("Func"));
}
break;
}
base.WndProc(ref m);
}

}
}