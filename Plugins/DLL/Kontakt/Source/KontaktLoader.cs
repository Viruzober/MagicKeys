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
KeyUnReg();
if (API.GetVUI() == "Kontakt")
{
KontaktNormalize();
LibLoaded();
}
KeyReg();
}

}
}