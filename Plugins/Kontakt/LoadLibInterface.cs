using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LoadLibInterface()
{
int[] KTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 5, 5, 10);
KeyGoToLibListUnReg();
if (ImgSearch(@"Images\KontaktIlyaEfimov\BayanR.bmp")[0] == 1)
{
                PluginsList[0]["PClass"] = typeof(IlyaEfimovBayanR).FullName;
VUILoader(@"KontaktLib\IlyaEfimovBayanR.vui");
IlyaEfimovBayanR.Loader();
Speak("Ilya Efimov Bayan right keyboard loaded");
}
else if (ImgSearch(@"Images\KontaktIlyaEfimov\BayanL.bmp")[0] == 1)
{
PluginsList[0]["PClass"] = typeof(IlyaEfimovBayanL).FullName;
VUILoader(@"KontaktLib\IlyaEfimovBayanL.vui");
IlyaEfimovBayanL.Loader();
Speak("Ilya Efimov Bayan left keyboard loaded");
}
else
{
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 10, 10, 10);
MouseClickDrag("Left", KTL[1]+5, KTL[2]+5, DP[1]+5, DP[2]+5, 1, 500);
LibNormalize();
KeyReg();
Speak("Данная библиотека пока недоступна");
}
}

}
}