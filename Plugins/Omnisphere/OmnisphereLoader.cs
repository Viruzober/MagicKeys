using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static void PluginLoad()
{
if (ImgSearch(@"Images\Omnisphere\Reg.bmp", true)[0] == 1)
{
VUIObjectSwitcher(true, "false", 1, 1);
}
else if (ImgSearch(@"Images\Omnisphere\Logo.bmp", true)[0] == 1)
{
VUIObjectSwitcher(true, "false", 2, 4);
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}