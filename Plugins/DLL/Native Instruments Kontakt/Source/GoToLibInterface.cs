using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class Kontakt
{
public static int[] TempCoords = new int[2];
public static void GoToLibInterface()
{
Speak("Searching for an interface");
int[] KTL = ImgSearch("KontaktTopLine");
TempCoords[0] = KTL[1];
TempCoords[1] = KTL[2];
MouseClickDrag("Left", KTL[1]+5, KTL[2]+5, Coords.X+15, Coords.Y+75, 0, 1000);
Thread.Sleep(300);
LibNormalize();
LoadLibInterface();
}

}
}