using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string CheckStatePixel(string Color, int X, int Y)
{
if (PixelSearch(X, Y, Color) == true)
{
return "Checked";
}
return "Not checked";
}

}
}