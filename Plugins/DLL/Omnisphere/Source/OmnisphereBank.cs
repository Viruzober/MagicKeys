using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Omnisphere
{

public static void OmnisphereBank(string To)
{
if (To == "Back")
{
int[] OUP = ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+160, P[1]+50, P[2]+185, 20);
if (OUP[0] == 1)
{
OmnisphereBankPage("Back");
return;
}
else if (OUP[0] == 0)
{
int[] OBP = ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+160, P[1]+50, P[2]+385, 20);
if (OBP[0] == 1)
{
string Bank = ImgToText(150, 20, OBP[1], OBP[2]-15, 3);
MouseClick("Left", OBP[5]+30, OBP[6]-15, 1, 0, 0, 10);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
Speak(Bank);
return;
}
}
}
else if (To == "Next")
{
int[] ODW = ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+360, P[1]+50, P[2]+385, 20);
if (ODW[0] == 1)
{
OmnisphereBankPage("Next");
return;
}
else if (ODW[0] == 0)
{
int[] OBP = ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+160, P[1]+50, P[2]+385, 20);
if (OBP[0] == 1)
{
string Bank = ImgToText(150, 20, OBP[1], OBP[2]+15, 3);
MouseClick("Left", OBP[5]+30, OBP[6]+15, 1, 0, 0, 10);
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
Speak(Bank);
return;
}
}
}
}

public static void BankName()
{
int[] OBP = ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+160, P[1]+50, P[2]+385, 20);
string Bank = ImgToText(150, 25, OBP[1], OBP[2], 3);
Thread.Sleep(100);
Speak(Bank);
}

}
}