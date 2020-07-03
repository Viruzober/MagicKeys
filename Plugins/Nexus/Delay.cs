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
Slider("Mix", 365, 355, "V", 1.38, 1.6);
KeyReg();
}

public static void DelayMod()
{
KeyUnReg();
Slider("Mod", 425, 355, "V", 1.38, 1.6);
KeyReg();
}

public static void DelayTime()
{
KeyUnReg();
Slider("Time", 250, 415, "V", 1.38, 1.6);
KeyReg();
}

public static void DelayFeedBack()
{
KeyUnReg();
Slider("FeedBack", 305, 415, "V", 1.38, 1.6);
KeyReg();
}

public static void DelayLoCut()
{
KeyUnReg();
Slider("LoCut", 365, 415, "V", 1.38, 1.6);
KeyReg();
}

public static void DelayHiCut()
{
KeyUnReg();
Slider("HiCut", 420, 415, "V", 1.38, 1.6);
KeyReg();
}

}
}