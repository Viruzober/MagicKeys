using System;
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
string key = ((Keys)(((int)m.LParam >> 16) & 0xFFFF)).ToString();
if (VUIKeys.ContainsKey(modifier+key) == true)
{
(string Func, string Param) = FuncParse(VUIKeys[modifier+key]);
if (API.GetPClass() == "MagicKeys")
{
List<string> VUFValues = Ini.IniReadValues(API.GetVUIPath()+API.GetVUIExt().Substring(0, API.GetVUIExt().Length - 4)+".vuf", Func);
VUFInvoke(VUFValues);
}
else
{
InvokeFromString(Func, Param);
}
}
break;
}
base.WndProc(ref m);
}

}
}