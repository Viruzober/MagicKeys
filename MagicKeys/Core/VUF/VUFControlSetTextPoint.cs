using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFControlSetTextPoint(string Param)
{
string[] FP = Param.Split(",");
ControlSetTextPoint(
Coords.X+Convert.ToInt32(FP[0]),
Coords.Y+Convert.ToInt32(FP[1]),
FP[2]
);
}

}
}