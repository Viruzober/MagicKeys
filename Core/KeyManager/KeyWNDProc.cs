using System;
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
if (VUIKeys.ContainsKey(modifier+"+"+key) == true)
{
InvokeFromString(FuncParse(VUIKeys[modifier+"+"+key]), ParamParse(VUIKeys[modifier+"+"+key]));
}
else if (VUIKeys.ContainsKey(key) == true)
{
InvokeFromString(FuncParse(VUIKeys[key]), ParamParse(VUIKeys[key]));
}
break;
}
base.WndProc(ref m);
}

}
}