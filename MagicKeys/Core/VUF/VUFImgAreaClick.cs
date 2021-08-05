using System;

namespace MagicKeys
{
public partial class MagicKeys
{
public static void VUFImgAreaClick(String Param)
{
string[] PR = Param.Split(",");
int[] Img = ImgSearchArea(PR[0],
P[1]+Convert.ToInt32(PR[2]),
P[2]+Convert.ToInt32(PR[3]),
P[1]+Convert.ToInt32(PR[4]),
P[2]+Convert.ToInt32(PR[5]),
20);
if (Img[0] == 1)
{
if (PR[6] == "C")
{
MouseClick(PR[1], Img[5], Img[6], 1, 0, 0, 10);
}

if (PR[6] == "L")
{
MouseClick(PR[1], Img[1]-Convert.ToInt32(PR[7]), Img[6], 1, 0, 0, 10);
}

if (PR[6] == "R")
{
MouseClick(PR[1], Img[3]+Convert.ToInt32(PR[7]), Img[6], 1, 0, 0, 10);
}

if (PR[6] == "U")
{
MouseClick(PR[1], Img[5], Img[2]-Convert.ToInt32(PR[7]), 1, 0, 0, 10);
}

if (PR[6] == "D")
{
MouseClick(PR[1], Img[5], Img[4]+Convert.ToInt32(PR[7]), 1, 0, 0, 10);
}

Speak("Done");
return;
}
Speak("Image not found");
}

}
}