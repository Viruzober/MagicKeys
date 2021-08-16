using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFSlider(string Param)
{
string[] FP = Param.Split(",");
Slider(
FP[0],
Coords.X+Convert.ToInt32(FP[1]),
Coords.Y+Convert.ToInt32(FP[2]),
FP[3],
Convert.ToDouble(FP[4]),
Convert.ToDouble(FP[5])
);
}

}
}