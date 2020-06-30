namespace MagicKeys
{
    public partial class MagicKeys
{
public static int[] GetMousePosition()
{
WinPoint WP;
GetCursorPos(out WP);
int[] MP = new int[2] {WP.X, WP.Y};
return MP;
}
}
}