using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFImgClick(String Param)
{
string[] PR = Param.Split(",");
int[] Img = ImgSearchArea(PR[0], P[1], P[2], P[3], P[4], 20);
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