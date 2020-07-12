using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class PlugSound
{

public static void PluginLoad()
{
VUILoader(API.GetVUI());
KeyReg();
}

public static void PluginUnLoad()
{
KeyUnReg();
}

}
}