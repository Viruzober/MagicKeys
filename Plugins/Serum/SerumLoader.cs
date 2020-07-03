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
VUIObjectSwitcher(true, "false", 1, 5);
}
else
{
VUIObjectSwitcher(true, "false", 6, 6);
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}