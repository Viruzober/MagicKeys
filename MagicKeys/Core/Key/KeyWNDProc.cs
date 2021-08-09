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
KeyUnReg();
if (VUIKeys.ContainsKey(Key) == true)
{
(string Func, string Param) = FuncParse(VUIKeys[Key]);
if (API.GetActiveClass() == "lua")
{
LUAInvoke(Func, Param);
}
else if (API.GetActiveClass() == "MagicKeys")
{
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentScript(), Func);
List<string> Params = Ini.IniReadValues(API.GetCurrentScript(), Func);
VUFInvoke(Funcs, Params);
}
else
{
if(VUIKeys[Key].Split(",", 2)[0] == "Background")
{
if (Func == ThreadFunc.Split(",")[0])
{
ThreadFunc = string.Empty;
}
else
{
var BFObj = new BackgroundFuncObject(Func, Param);
BackgroundInvoke(BFObj);
}
}
else
{
InvokeFromString(Func, Param);
}
}
}
KeyReg();
break;
}
base.WndProc(ref m);
}

}
}