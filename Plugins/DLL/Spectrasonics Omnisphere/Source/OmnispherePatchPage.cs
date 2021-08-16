using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void OmnispherePatchPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", Coords.X+230, Coords.Y+380, Coords.X+270, Coords.Y+420, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", Coords.X+250, Coords.Y+395, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", Coords.X+220, Coords.Y+610, 1, 0, 0, 10);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", Coords.X+230, Coords.Y+590, Coords.X+270, Coords.Y+630, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", Coords.X+250, Coords.Y+615, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", Coords.X+220, Coords.Y+400, 1, 0, 0, 10);
}
Thread.Sleep(600);
int[] OBP = ImgSearchArea("BP", Coords.X+10, Coords.Y+390, Coords.X+50, Coords.Y+620, 20);
string Patch = ImgToText(150, 20, OBP[1], OBP[2], 3);
Speak(Patch);
}

}
}