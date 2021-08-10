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
}
}
break;
}
base.WndProc(ref m);
}

}
}