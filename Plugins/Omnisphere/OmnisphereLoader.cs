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
else
{
if (ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+160, P[1]+50, P[2]+385, 20)[0] == 0)
{
MouseClick("Left", P[1]+220, P[2]+170, 1, 0, 0, 10);
}
Thread.Sleep(100);
if (ImgSearchArea(@"Images\Omnisphere\BP.bmp", P[1]+10, P[2]+390, P[1]+50, P[2]+620, 20)[0] == 0)
{
MouseClick("Left", P[1]+220, P[2]+400, 1, 0, 0, 10);
}
Speak("OK");
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}