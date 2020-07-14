using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class PlugSound
{

public static void PluginLoad()
{
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}