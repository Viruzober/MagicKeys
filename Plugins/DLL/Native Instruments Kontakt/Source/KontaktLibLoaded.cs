using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Kontakt
{

public static void LibLoaded()
{
VUIObjectSwitcher(true, false, 3, 5);
if(ImageSearch("KontaktLibLoaded", true)[0] == 0)
{
VUIObjectSwitcher(true, true, 3, 5);
}
}

}
}