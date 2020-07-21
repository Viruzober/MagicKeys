using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
    public class KontaktKey : Form
{

protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
int modifier = (int)m.LParam & 0xFFFF;
Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
if (modifier == MKC.CTRL & key == Keys.D)
{
Kontakt.AllLibDelete();
}
else if (key == Keys.D)
{
Kontakt.LibDelete();
}
else if (key == Keys.Delete)
{
Speak("Для удаления нажмите D или Ctrl+D");
}
else if (key == Keys.Up)
{
Kontakt.LibNavigator("Back");
}
else if (key == Keys.Down)
{
Kontakt.LibNavigator("Next");
}
else if (key == Keys.I)
{
Kontakt.LibGetInfo();
}
else if (key == Keys.S)
{
Kontakt.LibGetSnapshot();
}
else if (key == Keys.V)
{
MagicKeys.Speak("It work");
}
break;
}
base.WndProc(ref m);
}

}
}