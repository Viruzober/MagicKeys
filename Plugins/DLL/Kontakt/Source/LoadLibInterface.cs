using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{

public static void LoadLibInterface()
{
int[] KTL = ImgSearch("KontaktTopLine");
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 5, 5, 10);
if (SubPluginLoad() == true) return;
SubPluginUnLoad();
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 10, 10, 10);
MouseClickDrag("Left", KTL[1]+5, KTL[2]+5, DP[1]+5, DP[2]+5, 1, 500);
LibNormalize();
Speak("Данная библиотека пока недоступна");
}

}
}