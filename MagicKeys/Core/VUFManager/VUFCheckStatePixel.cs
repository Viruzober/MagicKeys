using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void CheckStatePixel(string Param)
{
string[] FP = Param.Split("|");
CheckStatePixel(
FP[0],
Convert.ToInt32(FP[1]),
Convert.ToInt32(FP[2])
);
}

}
}