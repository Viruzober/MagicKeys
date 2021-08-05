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
string modifier = KeyParse((int)m.LParam & 0xFFFF);
int K = ((int)m.LParam >> 16) & 0xFFFF;
string key = GetKeyName(K);
KeyUnReg();
if (VUIKeys.ContainsKey(modifier+key) == true)
{
(string Func, string Param) = FuncParse(VUIKeys[modifier+key]);
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
InvokeFromString(Func, Param);
}
}
KeyReg();
break;
}
base.WndProc(ref m);
}

}
}