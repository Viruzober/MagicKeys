using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void OmnisphereBank(string To)
{
if (To == "Back")
{
int[] OUP = ImgSearchArea("BP", Coords.X+10, Coords.Y+160, Coords.X+50, Coords.Y+185, 20);
if (OUP[0] == 1)
{
OmnisphereBankPage("Back");
return;
}
else if (OUP[0] == 0)
{
int[] OBP = ImgSearchArea("BP", Coords.X+10, Coords.Y+160, Coords.X+50, Coords.Y+385, 20);
if (OBP[0] == 1)
{
string Bank = ImgToText(150, 20, OBP[1], OBP[2]-15, 3);
MouseClick("Left", OBP[5]+30, OBP[6]-15, 1, 0, 0, 10);
MouseClick("Left", Coords.X+220, Coords.Y+400, 1, 0, 0, 10);
Speak(Bank);
return;
}
}
}
else if (To == "Next")
{
int[] ODW = ImgSearchArea("BP", Coords.X+10, Coords.Y+360, Coords.X+50, Coords.Y+385, 20);
if (ODW[0] == 1)
{
OmnisphereBankPage("Next");
return;
}
else if (ODW[0] == 0)
{
int[] OBP = ImgSearchArea("BP", Coords.X+10, Coords.Y+160, Coords.X+50, Coords.Y+385, 20);
if (OBP[0] == 1)
{
string Bank = ImgToText(150, 20, OBP[1], OBP[2]+15, 3);
MouseClick("Left", OBP[5]+30, OBP[6]+15, 1, 0, 0, 10);
MouseClick("Left", Coords.X+220, Coords.Y+400, 1, 0, 0, 10);
Speak(Bank);
return;
}
}
}
}

public static void BankName()
{
int[] OBP = ImgSearchArea("BP", Coords.X+10, Coords.Y+160, Coords.X+50, Coords.Y+385, 20);
string Bank = ImgToText(150, 25, OBP[1], OBP[2], 3);
Thread.Sleep(100);
Speak(Bank);
}

}
}