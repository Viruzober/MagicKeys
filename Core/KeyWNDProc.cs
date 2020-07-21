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
int modifier = (int)m.LParam & 0xFFFF;
Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
if (VUIKeys.ContainsKey(KeyPars(modifier)+"+"+key.ToString()) == true)
{
InvokeFromString(VUIKeys[KeyPars(modifier)+"+"+key.ToString()]);
}
else if (VUIKeys.ContainsKey(key.ToString()) == true)
{
InvokeFromString(VUIKeys[key.ToString()]);
}
break;
}
base.WndProc(ref m);
}

}
}