using System.Drawing;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void KontaktNormalize()
{
while (ImgSearch("KontaktLogo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}

while (ImgSearch("KontaktBrowserOff", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
Application.DoEvents();
Bitmap BrowserShowCheck = CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", Coords.X+730, Coords.Y+17, 1, 0, 0, 10);
MouseClick("Left", Coords.X+730, Coords.Y+40, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 1, 1, 20, BrowserShowCheck);
}

while (ImgSearch("KontaktInfoShow", true)[0] == 1)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
Application.DoEvents();
Bitmap InfoShow = CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", Coords.X+405, Coords.Y+17, 1, 0, 0, 10);
MouseClick("Left", Coords.X+405, Coords.Y+85, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 1, 1, 20, InfoShow);
}
}

}
}