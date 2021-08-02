using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
namespace MagicKeys
{
public partial class Omnisphere
{
public static void OmnispherePatchPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", P[1]+230, P[2]+380, P[1]+270, P[2]+420, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+250, P[2]+395, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", P[1]+220, P[2]+610, 1, 0, 0, 10);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", P[1]+230, P[2]+590, P[1]+270, P[2]+630, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+250, P[2]+615, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
}
Thread.Sleep(600);
int[] OBP = ImgSearchArea("BP", P[1]+10, P[2]+390, P[1]+50, P[2]+620, 20);
string Patch = ImgToText(150, 20, OBP[1], OBP[2], 3);
Speak(Patch);
}
}
}