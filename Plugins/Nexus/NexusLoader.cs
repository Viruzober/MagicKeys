using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Nexus
{

public static void PluginLoad()
{
Mes = MagicKeys.GetPos;
VUILoader(@"Nexus\Nexus.vui");
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}