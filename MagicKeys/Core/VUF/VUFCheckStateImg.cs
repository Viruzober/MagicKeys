using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFCheckStateImg(string Param)
{
string[] FP = Param.Split(",");
string R = CheckStateImg(
FP[0],
Coords.X+Convert.ToInt32(FP[1]),
Coords.Y+Convert.ToInt32(FP[2]),
Coords.X+Convert.ToInt32(FP[3]),
Coords.Y+Convert.ToInt32(FP[4])
);
Speak(R);
return R;
}

}
}