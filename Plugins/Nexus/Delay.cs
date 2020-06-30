using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void DelayOnOff()
{
MouseClick("Left", P[1]+245, P[2]+365, 1, 0, 0, 10);
CheckBox(P[1]+245, P[2]+345, "#3AA1FF", "Delay");
}

public static void DelayType()
{
MouseClick("Left", P[1]+270, P[2]+365, 1, 0, 0, 10);
if (PixelSearch(P[1]+290, P[2]+340, "#3AA1FF") == true) Speak("Mono");
if (PixelSearch(P[1]+290, P[2]+355, "#3AA1FF") == true) Speak("Stereo");
if (PixelSearch(P[1]+290, P[2]+365, "#3AA1FF") == true) Speak("Cross");
if (PixelSearch(P[1]+290, P[2]+375, "#3AA1FF") == true) Speak("Pingpong");
}

public static void DelayMix()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Mix", "Введите значение для Mix от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+365, P[2]+355, P[1]+365, Height-10, 0, 10);
int V = P[2] + 355 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+365, P[2]+355, P[1]+365, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void DelayMod()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Mod", "Введите значение для Mod от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+425, P[2]+355, P[1]+425, Height-10, 0, 10);
int V = P[2] + 355 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+425, P[2]+355, P[1]+425, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void DelayTime()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Time", "Введите значение для Time от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+250, P[2]+415, P[1]+250, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+250, P[2]+415, P[1]+250, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void DelayFeedBack()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("FeedBack", "Введите значение для FeedBack от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+305, P[2]+415, P[1]+305, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+305, P[2]+415, P[1]+305, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void DelayLoCut()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("LoCut", "Введите значение для LoCut от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+365, P[2]+415, P[1]+365, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+365, P[2]+415, P[1]+365, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void DelayHiCut()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("HiCut", "Введите значение для HiCut от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+420, P[2]+415, P[1]+420, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+420, P[2]+415, P[1]+420, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

}
}