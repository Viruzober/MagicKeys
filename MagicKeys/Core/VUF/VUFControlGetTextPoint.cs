using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFControlGetTextPoint(string Param)
{
string[] FP = Param.Split(",");
string R = ControlGetTextPoint(
Coords.X+Convert.ToInt32(FP[0]),
Coords.Y+Convert.ToInt32(FP[1])
);
Speak(R);
return R;
}

}
}