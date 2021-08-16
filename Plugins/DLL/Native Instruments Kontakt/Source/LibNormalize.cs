using System.Drawing;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LibNormalize()
{
Bitmap FixTopLine = CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", Coords.X+15, Coords.Y+75, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 3, 3, 10, FixTopLine);
while (ImgSearch("KontaktTopLine", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
Bitmap SearchTopLine = CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", Coords.X+15, Coords.Y+75, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 3, 3, 10, SearchTopLine);
}

Bitmap ShowLibInterface = CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", Coords.X+640, Coords.Y+50, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 3, 3, 10, ShowLibInterface);
while (ImgSearch("KontaktLeftLine", true)[0] == 1)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
Bitmap SearchLeftLine = CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", Coords.X+640, Coords.Y+50, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 3, 3, 10, SearchLeftLine);
}
}

}
}