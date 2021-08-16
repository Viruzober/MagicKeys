using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFCheckStatePixel(string Param)
{
string[] FP = Param.Split(",");
string R = CheckStatePixel(
FP[0],
Coords.X+Convert.ToInt32(FP[1]),
Coords.Y+Convert.ToInt32(FP[2])
);
Speak(R);
return R;
}

}
}