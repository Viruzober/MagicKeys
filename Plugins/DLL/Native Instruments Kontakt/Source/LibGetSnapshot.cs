using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LibGetSnapshot()
{
int[] KLSS = ImageSearch("KontaktTopLine");
MouseClick("Left", KLSS[1]+620, KLSS[2]+20, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KLSS[1]+360, KLSS[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Snapshot = ImgToText(140, 25, KLSS[1] + 70, KLSS[2] + 35, 2);
MouseClick("Left", KLSS[1]+620, KLSS[2]+20, 1, 0, 0, 10);
Speak(Snapshot);
}

}
}