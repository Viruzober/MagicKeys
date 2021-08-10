using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Kontakt
{

public static string Progress()
{
int[] X = ImgSearchArea("Progress", P[1], P[2], P[3], P[4], 0);
if (X[0] == 1)
{
Speak((Math.Round((X[1]-P[1])/3.5)).ToString(), true);
return (Math.Round((X[1]-P[1])/3.5)).ToString();
}
else
{
Speak("0", true);
return "0";
}
}

public static void ProgressCancel()
{
MouseClick("Left", P[1]+340, P[2]+55, 1, 0, 0, 10);
}

}
}