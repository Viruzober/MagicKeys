using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string CheckStateImg(string Img, int X, int Y, int W, int H)
{
if (ImgSearchArea(Img, X, Y, W, H, 20)[0] == 1)
{
return "Checked";
}
return "Not checked";
}

}
}