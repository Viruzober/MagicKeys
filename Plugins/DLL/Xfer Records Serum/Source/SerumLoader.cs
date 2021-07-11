using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Serum
{

public static void SerumLoader()
{
        while(ImgSearchArea("Reg", P[1], P[2], P[1]+P[3], P[2]+P[4], 0)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearchArea("Reg", P[1], P[2], P[1]+P[3], P[2]+P[4], 0)[0] == 1)
{
VUILoader("Register");
return;
}
Speak("Before using this plugin follow the instructions found in the corresponding Settings folder");
}

}
}