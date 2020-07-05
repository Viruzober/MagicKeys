using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Serum
{

public static void PluginLoad()
{
VUILoader(@PluginsList[0]["VUI"]);
MouseClick("Left", P[1]+80, P[2]+5, 1, 0, 0, 10);
Thread.Sleep(200);
if (ImgSearch(@"Images\Serum\SerumLogo.bmp")[0] == 1)
{
VUIObjectSwitcher(true, "false", 6, 6);
MouseClick("Left", P[1]+80, P[2]+5, 1, 0, 0, 10);
}
else
{
VUIObjectSwitcher(true, "false", 1, 5);
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}