using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static string Progress()
{
int[] X = ImgSearchArea(@"Images\Kontakt\Progress.bmp", P[1], P[2], P[1]+P[3], P[2]+P[4], 0);
if (X[0] == 1)
{
Speak((Math.Round((X[1]-P[1])/3.5)).ToString());
return (Math.Round((X[1]-P[1])/3.5)).ToString();
}
else
{
Speak("0");
return "0";
}
}

public static void ProgressCancel()
{
MouseClick("Left", P[1]+350, P[2]+35, 1, 0, 0, 10);
}

}
}