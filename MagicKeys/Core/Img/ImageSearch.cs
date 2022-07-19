using System;
using System.IO;
using static MKLib;

namespace MagicKeys
{
public partial class MagicKeys
{

public static int[] ImageSearch(string imgPath, bool Window)
{
return ImgSearch(Path.Combine(API.GetImgPath(), imgPath+".bmp"), Window);
}

public static int[] ImageSearch(string imgPath)
{
return ImgSearch(Path.Combine(API.GetImgPath(), imgPath+".bmp"));
}

}
}