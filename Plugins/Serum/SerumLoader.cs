using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Serum
{

public static void PluginLoad()
{
VUILoader(@PluginsList[0]["VUI"]);
if (ImgSearch(@"Images\Serum\SerumReg.bmp")[0] == 1)
{
VUIObjectSwitcher(true, "false", 1, 6);
}
else
{
VUIObjectSwitcher(true, "false", 7, 7);
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}