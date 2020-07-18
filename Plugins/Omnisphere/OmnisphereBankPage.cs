using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Omnisphere
{

public static void OmnisphereBankPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea(@"Images\Omnisphere\FullHome.bmp", P[1]+230, P[2]+150, P[1]+270, P[2]+190, 0);
if (FH[0] == 1)
{
SoundPlay("End.ogg", 0);
return;
}
SoundPlay("Scrol.ogg", 0);
MouseClick("Left", P[1]+250, P[2]+170, 1, 0, 0, 10);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea(@"Images\Omnisphere\FullEnd.bmp", P[1]+230, P[2]+350, P[1]+270, P[2]+390, 0);
if (FH[0] == 1)
{
SoundPlay("End.ogg", 0);
return;
}
SoundPlay("Scrol.ogg", 0);
MouseClick("Left", P[1]+250, P[2]+370, 1, 0, 0, 10);
}
}

}
}