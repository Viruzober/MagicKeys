using System.Windows.Forms;

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
Ni.Text = T._("MagicKeys {0} is disabled", MagicKeys.GetVersion());
MKLib.Speak(T._("MagicKeys is disabled"));
MagicKeys.KeySwitch = 1;
}
else if (MagicKeys.KeySwitch == 1)
{
Ni.Text = T._("MagicKeys {0} is enabled", MagicKeys.GetVersion());
MKLib.Speak(T._("MagicKeys is enabled"));
MagicKeys.KeySwitch = 0;
}
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F2)
{
Exit(null, null);
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F4)
{
if (Settings.SoundTheme == true)
{
Settings.SoundTheme = false;
MKLib.Speak(T._("Sounds off"));
}
else
{
Settings.SoundTheme = true;
MKLib.Speak(T._("Sounds on"));
}
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F6)
{
SettingsShow(null, null);
}
break;
}
base.WndProc(ref m);
}

}
}