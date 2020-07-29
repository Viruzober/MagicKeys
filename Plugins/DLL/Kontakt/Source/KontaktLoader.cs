using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
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