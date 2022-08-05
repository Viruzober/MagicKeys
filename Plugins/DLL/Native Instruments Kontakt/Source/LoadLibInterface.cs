using static MagicKeys.MagicKeys;
using static MKLib;
using System.Drawing;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LoadLibInterface()
{
int[] KTL = ImageSearch("KontaktTopLine");
CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 5, 5, 10);

CreateBitmap(Coords.X, Coords.Y, Coords.W, Coords.H);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
DisplayTraffic(Coords.X, Coords.Y, Coords.W, Coords.H, 10, 10, 10);
MouseClickDrag("Left", KTL[1]+5, KTL[2]+5, TempCoords[0]+5, TempCoords[1]+5, 1, 500);
LibNormalize();
Speak("This library is currently inaccessible");
}

}
}