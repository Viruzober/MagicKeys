using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Nexus
{

public static void ReverbOnOff()
{
MouseClick("Left", P[1]+480, P[2]+365, 1, 0, 0, 10);
CheckBox(P[1]+480, P[2]+345, "#3AA1FF", "Reverb");
}

public static void ReverbType()
{
MouseClick("Left", P[1]+500, P[2]+365, 1, 0, 0, 10);
Thread.Sleep(50);
if (PixelSearch(P[1]+520, P[2]+345, "#3AA1FF") == true) Speak("Room");
if (PixelSearch(P[1]+520, P[2]+360, "#3AA1FF") == true) Speak("Hall");
if (PixelSearch(P[1]+520, P[2]+375, "#3AA1FF") == true) Speak("Arena");
}

public static void ReverbMix()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Mix", "Введите значение для Mix от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+595, P[2]+355, P[1]+420, Height-10, 0, 10);
int V = P[2] + 355 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+595, P[2]+355, P[1]+595, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void ReverbMod()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Mod", "Введите значение для Mod от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+655, P[2]+355, P[1]+655, Height-10, 0, 10);
int V = P[2] + 355 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+655, P[2]+355, P[1]+655, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void ReverbDec()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Dec", "Введите значение для Dec от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+540, P[2]+415, P[1]+540, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+540, P[2]+415, P[1]+540, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void ReverbPreDelay()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Pre-dly", "Введите значение для Pre-dly от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+480, P[2]+415, P[1]+480, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+480, P[2]+415, P[1]+480, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void ReverbLoCut()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Lo-Cut", "Введите значение для Lo-Cut от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+595, P[2]+415, P[1]+595, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+595, P[2]+415, P[1]+595, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

public static void ReverbHiCut()
{
KeyUnReg();
int Input = Convert.ToInt32(InputBox("Hi-Cut", "Введите значение для Hi-Cut от 1 до 100", 1, 100));
if (Input == 0)
{
KeyReg();
return;
}
WindowMover(50, 250, true);
MouseClickDrag("Left", P[1]+655, P[2]+415, P[1]+655, Height-10, 0, 10);
int V = P[2] + 415 - (Convert.ToInt32(Convert.ToInt32(Input*1.38)*1.6));
MouseClickDrag("Left", P[1]+655, P[2]+415, P[1]+655, V, 0, 10);
WindowMover(DP[1], DP[2], false);
KeyReg();
Speak("OK");
}

}
}