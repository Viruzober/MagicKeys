using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void GoToLibInterface()
{
Speak("Идёт поиск интерфейса");
int[] KTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
DP[1] = KTL[1];
DP[2] = KTL[2];
MouseClickDrag("Left", KTL[1]+5, KTL[2]+5, P[1]+15, P[2]+75, 0, 1000);
Thread.Sleep(300);
LibNormalize();
LoadLibInterface();
}

}
}