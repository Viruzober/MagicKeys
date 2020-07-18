using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static void PluginLoad()
{
MouseClick("Left", P[1]+200, P[2]+10, 1, 0, 0, 10);
while(
ImgSearch(@"Images\Omnisphere\Reg.bmp", true)[0] == 0 &
ImgSearch(@"Images\Omnisphere\Logo.bmp", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearch(@"Images\Omnisphere\Reg.bmp", true)[0] == 1)
{
VUILoader(@"Omnisphere\OmnisphereReg.vui");
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}