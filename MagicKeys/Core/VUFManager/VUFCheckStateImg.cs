using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFCheckStateImg(string Param)
{
string[] FP = Param.Split("|");
CheckStateImg(
FP[0],
Convert.ToInt32(FP[1]),
Convert.ToInt32(FP[2]),
Convert.ToInt32(FP[3]),
Convert.ToInt32(FP[4])
);
}

}
}