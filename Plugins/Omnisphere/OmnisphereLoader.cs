using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static void PluginLoad()
{
while(
ImgSearch(@"Images\Omnisphere\Splash.bmp", true)[0] == 0 &
ImgSearch(@"Images\Omnisphere\Reg.bmp", true)[0] == 0 &
ImgSearch(@"Images\Omnisphere\Logo.bmp", true)[0] == 0)
{
if (WinActive(API.GetWTitle(), API.GetWClass()) == false)
{
return;
}
}
if (ImgSearch(@"Images\Omnisphere\Splash.bmp", true)[0] == 1)
{
MouseClick("Left", P[1]+100, P[2]+10, 1, 0, 0, 10);
Thread.Sleep(500);
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