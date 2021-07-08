using System.Threading;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{

public static void LibLoaded()
{
VUIObjectSwitcher(true, "false", 4, 6);
if(ImgSearch("KontaktLibLoaded", true)[0] == 0)
{
VUIObjectSwitcher(true, "true", 4, 6);
}
}

}
}