using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFSetFocusControlPoint(string Param)
{
string[] FP = Param.Split(",");
SetFocusControlPoint(Coords.X+Convert.ToInt32(FP[0]), Coords.Y+Convert.ToInt32(FP[1]));
}

}
}