using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string CheckStateImg(string Img, int X, int Y, int W, int H)
{
if (ImgSearchArea(Img, P[1]+X, P[2]+Y, P[3]+W, P[4]+H, 20)[0] == 1)
{
return "Checked";
}
return "Not checked";
}

}
}