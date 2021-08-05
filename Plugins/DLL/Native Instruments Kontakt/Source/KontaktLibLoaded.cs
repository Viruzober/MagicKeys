using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{
public static void LibLoaded()
{
VUIObjectSwitcher(true, "false", 3, 5);
if(ImgSearch("KontaktLibLoaded", true)[0] == 0)
{
VUIObjectSwitcher(true, "true", 3, 5);
}
}

}
}