using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Nexus
{

public static void DelayOnOff()
{
MouseClick("Left", Coords.X+245, Coords.Y+365, 1, 0, 0, 10);
CheckBox(Coords.X+245, Coords.Y+345, "#3AA1FF", "Delay");
}

public static void DelayType()
{
MouseClick("Left", Coords.X+270, Coords.Y+365, 1, 0, 0, 10);
if (PixelSearch(Coords.X+290, Coords.Y+340, "#3AA1FF") == true)
{
Speak("Mono");
}

if (PixelSearch(Coords.X+290, Coords.Y+355, "#3AA1FF") == true)
{
Speak("Stereo");
}

if (PixelSearch(Coords.X+290, Coords.Y+365, "#3AA1FF") == true)
{
Speak("Cross");
}

if (PixelSearch(Coords.X+290, Coords.Y+375, "#3AA1FF") == true)
{
Speak("Pingpong");
}
}

public static void DelayMix()
{
Slider("Mix", 365, 355, "V", 1.38, 1.6);
}

public static void DelayMod()
{
Slider("Mod", 425, 355, "V", 1.38, 1.6);
}

public static void DelayTime()
{
Slider("Time", 250, 415, "V", 1.38, 1.6);
}

public static void DelayFeedBack()
{
Slider("Feedback", 305, 415, "V", 1.38, 1.6);
}

public static void DelayLoCut()
{
Slider("LoCut", 365, 415, "V", 1.38, 1.6);
}

public static void DelayHiCut()
{
Slider("HiCut", 420, 415, "V", 1.38, 1.6);
}

}
}