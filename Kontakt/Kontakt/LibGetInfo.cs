using System.Threading.Tasks;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LibGetInfo()
{
int[] KTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
Thread.Sleep(100);
MouseClick("Left", KTL[1]+380, KTL[2]+15, 1, 0, 0, 10);
Thread.Sleep(100);
string Name = ImgToText(200, 30, KTL[1] + 70, KTL[2] + 5, 2);
string AudioChannel = ImgToText(50, 25, KTL[1] + 100, KTL[2] + 25, 2);
string MidiChannel = ImgToText(120, 45, KTL[1] + 70, KTL[2] + 40, 2);
MouseClick("Left", KTL[1]+620, KTL[2]+20, 1, 0, 0, 10);
Speak(Name+", Audio Channel "+AudioChannel+", Midi channel "+MidiChannel);
}

}
}