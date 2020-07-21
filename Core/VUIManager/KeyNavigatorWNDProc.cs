using System;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public class KeyNavigator : Form
{

protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
int modifier = (int)m.LParam & 0xFFFF;
Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F3)
{
MessageBox.Show(modifier.ToString(), "");
MagicKeys.HelpForm();
}
else if (modifier == (MKC.CTRL|MKC.SHIFT) & key == Keys.F4)
{
MagicKeys.LoopError = true;
MagicKeys.Speak("Зацикливание остановленно. Нажмите Ctrl+Shift+F1 чтобы возобновить работу MagicKeys");
}
else if (modifier == MKC.SHIFT & key == Keys.Tab)
{
MagicKeys.VUIObjectNavigator("Back");
}
else if (key == Keys.Tab)
{
MagicKeys.VUIObjectNavigator("Next");
}
else if (key == Keys.Left)
{
MagicKeys.VUIObjectNavigator("Back");
}
else if (key == Keys.Right)
{
MagicKeys.VUIObjectNavigator("Next");
}
else if (key == Keys.F1)
{
MagicKeys.VUIObjectHelp();
}
else if (key == Keys.Enter)
{
MagicKeys.VUIObjectEnter();
}
else if (key == Keys.Space)
{
MagicKeys.VUIObjectEnter();
}
break;
}
base.WndProc(ref m);
}

}
}