using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFSetFocusControlPoint(string Param)
{
string[] FP = Param.Split(",");
SetFocusControlPoint(P[1]+Convert.ToInt32(FP[0]), P[2]+Convert.ToInt32(FP[1]));
}

}
}