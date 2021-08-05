using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Omnisphere
{
public static void OmnisphereBankPage(string To)
{
if (To == "Back")
{
int[] FH = ImgSearchArea("FullHome", P[1]+230, P[2]+150, P[1]+270, P[2]+190, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+250, P[2]+170, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", P[1]+220, P[2]+370, 1, 0, 0, 10);
}
else if (To == "Next")
{
int[] FH = ImgSearchArea("FullEnd", P[1]+230, P[2]+350, P[1]+270, P[2]+390, 20);
if (FH[0] == 1)
{
SoundPlay("End", 0);
return;
}
SoundPlay("Scrol", 0);
MouseClick("Left", P[1]+250, P[2]+370, 1, 0, 0, 10);
Thread.Sleep(300);
MouseClick("Left", P[1]+220, P[2]+170, 1, 0, 0, 10);
}
Thread.Sleep(600);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
int[] OBP = ImgSearchArea("BP", P[1]+10, P[2]+160, P[1]+50, P[2]+385, 20);
string Bank = ImgToText(150, 20, OBP[1], OBP[2], 3);
Speak(Bank);
}

}
}