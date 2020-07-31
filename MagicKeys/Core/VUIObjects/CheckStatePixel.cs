using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string CheckStatePixel(string Color, int X, int Y)
{
if (PixelSearch(P[1]+X, P[2]+Y, Color) == true)
{
return "Checked";
}
return "Not checked";
}

}
}