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
Slider("CutOff", 125, 350, "V", 1.38, 1.6);
}

public static void MasterFilterRes()
{
Slider("Res", 185, 350, "V", 1.38, 1.6);
}

public static void MasterFilterType()
{
MouseClick("Left", P[1]+70, P[2]+420, 1, 0, 0, 10);
if (PixelSearch(P[1]+90, P[2]+400, "#3AA1FF") == true)
{
Speak("Lp");
}

if (PixelSearch(P[1]+90, P[2]+410, "#3AA1FF") == true)
{
Speak("Hp");
}

if (PixelSearch(P[1]+90, P[2]+425, "#3AA1FF") == true)
{
Speak("Bp");
}

if (PixelSearch(P[1]+90, P[2]+440, "#3AA1FF") == true)
{
Speak("Ntch");
}
}

public static void MasterFilterSlope()
{
MouseClick("Left", P[1]+145, P[2]+420, 1, 0, 0, 10);
if (PixelSearch(P[1]+165, P[2]+410, "#3AA1FF") == true)
{
Speak("6");
}

if (PixelSearch(P[1]+165, P[2]+420, "#3AA1FF") == true)
{
Speak("12");
}

if (PixelSearch(P[1]+165, P[2]+430, "#3AA1FF") == true)
{
Speak("24");
}
}

}
}