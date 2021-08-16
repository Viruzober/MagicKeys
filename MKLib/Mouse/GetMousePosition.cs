public static partial class MKLib
{

public static int[] GetMousePosition()
{
WinPoint WP;
GetCursorPos(out WP);
int[] MP = new int[2] {WP.X, WP.Y};
return MP;
}

}