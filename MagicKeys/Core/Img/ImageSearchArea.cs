using System;
using System.IO;
using static MKLib;

namespace MagicKeys
{
public partial class MagicKeys
{

public static int[] ImageSearchArea(string imgPath, int X, int Y, int W, int H, int Variant)
{
return MKLib.ImgSearchArea(Path.Combine(API.GetImgPath(), imgPath+".bmp"), X, Y, W, H, Variant);
}

}
}