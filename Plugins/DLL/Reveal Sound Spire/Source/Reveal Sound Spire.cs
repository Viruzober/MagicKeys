using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{

public partial class RevealSoundSpire
{

public string BP = "Bank";
public void Library()
{
if (ImgSearch("Lib", true)[0] == 0)
{
MouseClick("Left", Coords.X+210, Coords.Y+20, 1, 0, 0, 10);
}
else
{
MouseClick("Left", Coords.X+325, Coords.Y+20, 1, 0, 0, 10);
}
Thread.Sleep(200);
MouseClick("Left", Coords.X+200, Coords.Y+85, 1, 0, 0, 10);
VUILoader("Library");
}

public void GoToMain()
{
MouseClick("Left", Coords.X+325, Coords.Y+20, 1, 0, 0, 10);
VUILoader("Spire");
}

public void ChangeBank(string Key)
{
int[] BImg = ImgSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 20);
if (BImg[0] == 0)
{
MouseClick("Left", Coords.X+210, Coords.Y+85, 2, 0, 0, 10);
}
else
{
if (BP == "Preset")
{
MouseClick("Left", BImg[1], BImg[2], 2, 0, 0, 10);
BP = "Bank";
}
}
KeySend("Keys", Key, 50, 50);
BImg = ImgSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 20);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 4));
}

public void ChangePreset(string Key)
{
int[] PImg = ImgSearchArea("Presets", Coords.X+340, Coords.Y+50, Coords.X+1000, Coords.Y+500, 20);
if (PImg[0] == 0)
{
MouseClick("Left", Coords.X+420, Coords.Y+80, 1, 0, 0, 10);
Thread.Sleep(50);
if (ImgSearchArea("Presets", Coords.X+340, Coords.Y+50, Coords.X+1000, Coords.Y+500, 20)[0] == 0)
{
int[] BImg = ImgSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 20);
MouseClick("Left", BImg[1], BImg[2], 2, 0, 0, 10);
Speak("Bank not selected");
return;
}
}
else
{
if (BP == "Bank")
{
MouseClick("Left", PImg[1], PImg[2], 1, 0, 0, 10);
BP = "Preset";
}
}
KeySend("Keys", Key, 50, 100);
PImg = ImgSearchArea("Presets", Coords.X+340, Coords.Y+50, Coords.X+1000, Coords.Y+500, 20);
Speak(ImgToText(150, 20, PImg[1], PImg[2], 4));
}

public void SelectBank()
{
int[] BImg = ImgSearchArea("Banks", Coords.X+50, Coords.Y+50, Coords.X+250, Coords.Y+500, 20);
MouseClick("Left", BImg[5], BImg[6], 1, 0, 0, 10);
Speak(ImgToText(150, 20, BImg[1], BImg[2], 2)+" selected");
}

public void Rescan()
{
MouseClick("Left", Coords.X+355, Coords.Y+510, 1, 0, 0, 10);
}

public void SpeakPreset(string To)
{
if (ImgSearch("Lib", true)[0] == 1)
{
Speak("Please open library and select bank");
return;
}
if (To == "Previous")
{
MouseClick("Left", Coords.X+295, Coords.Y+25, 1, 0, 0, 10);
}
else
{
MouseClick("Left", Coords.X+330, Coords.Y+25, 1, 0, 0, 10);
}
Speak(ImgToText(150, 20, Coords.X+130, Coords.Y+15, 3));
}

public void Options()
{
MouseClick("Left", Coords.X+380, Coords.Y+25, 1, 0, 0, 10);
}

}
}