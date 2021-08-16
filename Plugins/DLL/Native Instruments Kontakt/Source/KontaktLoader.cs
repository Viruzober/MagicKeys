using static MagicKeys.MagicKeys;
using static MKLib;

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