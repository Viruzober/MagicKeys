using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
namespace MagicKeys
{
public partial class Omnisphere
{
public static void OmnispherePatch(string To)
{
if (To == "Back")
{
int[] OUP = ImgSearchArea("BP", P[1]+10, P[2]+390, P[1]+50, P[2]+415, 20);
if (OUP[0] == 1)
{
OmnispherePatchPage("Back");
return;
}
else if (OUP[0] == 0)
{
int[] OBP = ImgSearchArea("BP", P[1]+10, P[2]+390, P[1]+50, P[2]+620, 20);
if (OBP[0] == 1)
{
string Patch = ImgToText(150, 20, OBP[1], OBP[2]-15, 3);
MouseClick("Left", OBP[5]+30, OBP[6]-15, 1, 0, 0, 10);
Speak(Patch);
}
}
}
else if (To == "Next")
{
int[] ODW = ImgSearchArea("BP", P[1]+10, P[2]+590, P[1]+50, P[2]+620, 20);
if (ODW[0] == 1)
{
OmnispherePatchPage("Next");
return;
}
else if (ODW[0] == 0)
{
int[] OBP = ImgSearchArea("BP", P[1]+10, P[2]+390, P[1]+50, P[2]+620, 20);
if (OBP[0] == 1)
{
string Patch = ImgToText(150, 20, OBP[1], OBP[2]+15, 3);
MouseClick("Left", OBP[5]+30, OBP[6]+15, 1, 0, 0, 10);
Speak(Patch);
}
}
}
}
public static void PatchName()
{
int[] OBP = ImgSearchArea("BP", P[1]+10, P[2]+390, P[1]+50, P[2]+620, 20);
string Patch = ImgToText(150, 25, OBP[1], OBP[2], 3);
Thread.Sleep(100);
Speak(Patch);
}
}
}