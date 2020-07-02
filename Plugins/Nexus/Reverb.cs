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
Slider("Mix", 595, 355, "V", 1.38, 1.6);
KeyReg();
}

public static void ReverbMod()
{
KeyUnReg();
Slider("Mod", 655, 355, "V", 1.38, 1.6);
KeyReg();
}

public static void ReverbDec()
{
KeyUnReg();
Slider("Dec", 540, 415, "V", 1.38, 1.6);
KeyReg();
}

public static void ReverbPreDelay()
{
KeyUnReg();
Slider("PreDelay", 480, 415, "V", 1.38, 1.6);
KeyReg();
}

public static void ReverbLoCut()
{
KeyUnReg();
Slider("LoCut", 595, 415, "V", 1.38, 1.6);
KeyReg();
}

public static void ReverbHiCut()
{
KeyUnReg();
Slider("HiCut", 655, 415, "V", 1.38, 1.6);
KeyReg();
}

}
}