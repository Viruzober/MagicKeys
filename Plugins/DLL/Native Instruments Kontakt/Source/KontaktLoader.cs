using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
namespace MagicKeys
{
public partial class Kontakt
{
public static void KontaktLoader()
{
KontaktNormalize();
LibLoaded();
}
public static void LibListLoader()
{
SubPluginUnLoad();
LibNormalize();
}
}
}