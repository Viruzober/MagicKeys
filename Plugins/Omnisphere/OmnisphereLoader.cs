using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Omnisphere
{

public static void PluginLoad()
{
VUILoader(@PluginsList[0]["VUI"]);
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}