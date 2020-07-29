using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Omnisphere
{

public static void PluginLoad()
{
MouseClick("Left", P[1]+300, P[2]+10, 1, 0, 0, 10);
while(
ImgSearch("Reg", true)[0] == 0 &
ImgSearch("Logo", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearch("Reg", true)[0] == 1)
{
VUILoader("OmnisphereReg");
}
else
{
AudoSelect();
}
}

}
}