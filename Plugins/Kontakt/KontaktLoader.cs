using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void PluginLoad()
{
VUILoader(@PluginsList[0]["VUI"]);
if (PluginsList[0]["VUI"] == @"Kontakt\Kontakt.vui")
{
KontaktNormalize();
LibLoaded();
}
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}