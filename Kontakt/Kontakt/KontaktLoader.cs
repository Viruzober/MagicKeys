using System;
using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void PluginLoad()
{
if (API.GetVUIName() == "Kontakt")
{
KontaktNormalize();
LibLoaded();
}
}

}
}