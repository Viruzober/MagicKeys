using System.Windows.Forms;
using Windows.Security.Authentication.Identity;

namespace MagicKeys
{
    public class OmnisphereKey : Form
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
Omnisphere.OmnisphereBankPage("Back");
}
else if (modifier == MKC.CTRL & key == Keys.End)
{
Omnisphere.OmnisphereBankPage("Next");
}
else if (modifier == MKC.CTRL & key == Keys.Prior)
{
Omnisphere.OmnispherePatchPage("Back");
}
else if (modifier == MKC.CTRL & key == Keys.Next)
{
Omnisphere.OmnispherePatchPage("Next");
}
else if (key == Keys.Home)
{
Omnisphere.OmnisphereBank("Back");
}
else if (key == Keys.End)
{
Omnisphere.OmnisphereBank("Next");
}
else if (key == Keys.Prior)
{
Omnisphere.OmnispherePatch("Back");
}
else if (key == Keys.Next)
{
Omnisphere.OmnispherePatch("Next");
}
else if (key == Keys.B)
{
Omnisphere.BankName();
}
else if (key == Keys.P)
{
Omnisphere.PatchName();
}
break;
}
base.WndProc(ref m);
}

}
}