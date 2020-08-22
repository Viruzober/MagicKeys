using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{

public static void KontaktNormalize()
{
while (ImgSearch("KontaktLogo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false) return;
}
while (ImgSearch("KontaktBrowserOff", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false) return;
Application.DoEvents();
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+730, P[2]+17, 1, 0, 0, 10);
MouseClick("Left", P[1]+730, P[2]+40, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 1, 1, 20);
}
while (ImgSearch("KontaktInfoShow", true)[0] == 1)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false) return;
Application.DoEvents();
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+405, P[2]+17, 1, 0, 0, 10);
MouseClick("Left", P[1]+405, P[2]+85, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 1, 1, 20);
}
}

}
}