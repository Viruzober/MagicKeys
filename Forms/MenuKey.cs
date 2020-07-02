using System;
using System.Windows.Forms;
using System.IO;

namespace MagicKeys
{
public partial class Menu : Form
{

protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
int modifier = (int)m.LParam & 0xFFFF;
Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F1)
{
if (MagicKeys.KeySwitch == 0)
{
Ni.Text = "MagicKeys выключен";
MagicKeys.Speak("MagicKeys выключенн");
MagicKeys.KeySwitch = 1;
}
else if (MagicKeys.KeySwitch == 1)
{
Ni.Text = "MagicKeys включён";
MagicKeys.Speak("MagicKeys включён");
MagicKeys.KeySwitch = 0;
}
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F2)
{
Exit(null, null);
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F5)
{
if (MagicKeys.SoundTheme == true)
{
MagicKeys.SoundTheme = false;
MagicKeys.Speak("Звук отключён");
}
else
{
MagicKeys.SoundTheme = true;
MagicKeys.Speak("Звук включён");
}
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F6)
{
Settings(null, null);
}
break;
}
base.WndProc(ref m);
}

}
}