using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LibNavigator(string NavigateTo)
{
if (NavigateTo == "Back")
{
if (ImgSearch("KontaktLibListStart")[0] == 1)
{
SoundPlay("End", false);
}
else
{
int[] KTL = ImgSearch("KontaktTopLine");
MouseClick("Left", KTL[1]+5, KTL[2]-20, 1, 0, 0, 10);
Thread.Sleep(100);
int[] NKTL = ImgSearch("KontaktTopLine");
string text = ImgToText(200, 30, NKTL[1] + 70, NKTL[2] + 5, 2);
Speak(text);
}
}
else if (NavigateTo == "Next")
{
if (ImgSearch("KontaktLibListEnd")[0] == 1)
{
SoundPlay("End", false);
}
else
{
int[] KTL = ImgSearch("KontaktTopLine");
MouseClick("Left", KTL[1]+5, KTL[2]+40, 1, 0, 0, 10);
Thread.Sleep(100);
int[] NKTL = ImgSearch("KontaktTopLine");
string text = ImgToText(200, 30, NKTL[1] + 70, NKTL[2] + 5, 2);
Speak(text);
}
}
}

}
}