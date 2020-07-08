using System.Windows.Forms;
using Windows.Security.Authentication.Identity;

namespace MagicKeys
{
    public class NexusKey : Form
{

protected override void WndProc(ref Message m)
{
switch (m.Msg)
{
case MKC.WM_HOTKEY:
int modifier = (int)m.LParam & 0xFFFF;
Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
if (modifier == MKC.CTRL & key == Keys.Home)
{
Nexus.NexusBankPage("Back");
}
else if (modifier == MKC.CTRL & key == Keys.End)
{
Nexus.NexusBankPage("Next");
}
else if (modifier == MKC.CTRL & key == Keys.Prior)
{
Nexus.NexusPatchPage("Back");
}
else if (modifier == MKC.CTRL & key == Keys.Next)
{
Nexus.NexusPatchPage("Next");
}
else if (key == Keys.Home)
{
Nexus.NexusBank("Back");
}
else if (key == Keys.End)
{
Nexus.NexusBank("Next");
}
else if (key == Keys.Prior)
{
Nexus.NexusPatch("Back");
}
else if (key == Keys.Next)
{
Nexus.NexusPatch("Next");
}
else if (key == Keys.S)
{
MagicKeys.InvokeFromString("KeyUnReg");
Nexus.NexusSearch();
MagicKeys.InvokeFromString("KeyReg");
}
break;
}
base.WndProc(ref m);
}

}
}