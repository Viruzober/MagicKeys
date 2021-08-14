using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFImgClick(String Param)
{
string[] PR = Param.Split(",");
int[] Img = ImgSearchArea(PR[0], Coords.X, Coords.Y, Coords.W, Coords.H, 20);
if (Img[0] == 1)
{
MouseClick(PR[1], Img[5], Img[6], 1, 0, 0, 10);
Speak("Done");
return;
}
Speak("Image not found");
}

}
}