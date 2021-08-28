using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void OmnisphereBankPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", Coords.X+230, Coords.Y+150, Coords.X+270, Coords.Y+190, 20);
if (FH[0] == 1)
{
SoundPlay("End", false);
return;
}
SoundPlay("Scrol", false);
MouseClick("Left", Coords.X+250, Coords.Y+170, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", Coords.X+220, Coords.Y+370, 1, 0, 0, 10);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", Coords.X+230, Coords.Y+350, Coords.X+270, Coords.Y+390, 20);
if (FH[0] == 1)
{
SoundPlay("End", false);
return;
}
SoundPlay("Scrol", false);
MouseClick("Left", Coords.X+250, Coords.Y+370, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", Coords.X+220, Coords.Y+170, 1, 0, 0, 10);
}
Thread.Sleep(600);
MouseClick("Left", Coords.X+220, Coords.Y+400, 1, 0, 0, 10);
int[] OBP = ImgSearchArea("BP", Coords.X+10, Coords.Y+160, Coords.X+50, Coords.Y+385, 20);
string Bank = ImgToText(150, 20, OBP[1], OBP[2], 3);
Speak(Bank);
}

}
}