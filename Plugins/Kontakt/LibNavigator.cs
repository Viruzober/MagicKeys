using System.Threading.Tasks;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LibNavigator(string NavigateTo)
{
if (NavigateTo == "Back")
{
if (ImgSearch(@"Images\Kontakt\KontaktLibListStart.bmp")[0] == 1)
{
SoundPlay("End.ogg", 0);
}
else
{
int[] KTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
MouseClick("Left", KTL[1]+5, KTL[2]-20, 1, 0, 0, 10);
Thread.Sleep(100);
int[] NKTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
string text = ImgToText(200, 30, NKTL[1] + 70, NKTL[2] + 5, 2);
Speak(text);
}
}
else if (NavigateTo == "Next")
{
if (ImgSearch(@"Images\Kontakt\KontaktLibListEnd.bmp")[0] == 1)
{
SoundPlay("End.ogg", 0);
}
else
{
int[] KTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
MouseClick("Left", KTL[1]+5, KTL[2]+40, 1, 0, 0, 10);
Thread.Sleep(100);
int[] NKTL = ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp");
string text = ImgToText(200, 30, NKTL[1] + 70, NKTL[2] + 5, 2);
Speak(text);
}
}
}

}
}