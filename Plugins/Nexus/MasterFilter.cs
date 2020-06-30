using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void MasterFilterOnOff()
{
MouseClick("Left", P[1]+70, P[2]+365, 1, 0, 0, 10);
CheckBox(P[1]+70, P[2]+345, "#3AA1FF", "MasterFilter");
}

public static void MasterFilterCutOff()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("CutOff", "Введите значение для CutOff от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+125, P[2]+350, P[1]+125, Height-10, 0, 10);
int V = P[2] + 350 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+125, P[2]+350, P[1]+125, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void MasterFilterRes()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Res", "Введите значение для Res от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+185, P[2]+350, P[1]+185, Height-10, 0, 10);
int V = P[2] + 350 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+185, P[2]+350, P[1]+185, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void MasterFilterType()
{
MouseClick("Left", P[1]+70, P[2]+420, 1, 0, 0, 10);
if (PixelSearch(P[1]+90, P[2]+400, "#3AA1FF") == true) Speak("Lp");
if (PixelSearch(P[1]+90, P[2]+410, "#3AA1FF") == true) Speak("Hp");
if (PixelSearch(P[1]+90, P[2]+425, "#3AA1FF") == true) Speak("Bp");
if (PixelSearch(P[1]+90, P[2]+440, "#3AA1FF") == true) Speak("Ntch");
}

public static void MasterFilterSlope()
{
MouseClick("Left", P[1]+145, P[2]+420, 1, 0, 0, 10);
if (PixelSearch(P[1]+165, P[2]+410, "#3AA1FF") == true) Speak("6");
if (PixelSearch(P[1]+165, P[2]+420, "#3AA1FF") == true) Speak("12");
if (PixelSearch(P[1]+165, P[2]+430, "#3AA1FF") == true) Speak("24");
}

}
}