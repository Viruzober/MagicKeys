using System;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static string Progress()
{
int[] X = ImageSearchArea("Progress", Coords.X, Coords.Y, Coords.W, Coords.H, 0);
if (X[0] == 1)
{
Speak((Math.Round((X[1]-Coords.X)/3.5)).ToString(), true);
return (Math.Round((X[1]-Coords.X)/3.5)).ToString();
}
else
{
Speak("0", true);
return "0";
}
}

public static void ProgressCancel()
{
MouseClick("Left", Coords.X+340, Coords.Y+55, 1, 0, 0, 10);
}

}
}