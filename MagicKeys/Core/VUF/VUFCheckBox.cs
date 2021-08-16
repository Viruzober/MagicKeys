using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFCheckBox(string Param)
{
string[] FP = Param.Split(",");
CheckBox(
Coords.X+Convert.ToInt32(FP[0]),
Coords.Y+Convert.ToInt32(FP[1]),
FP[2],
FP[3]
);
}

}
}