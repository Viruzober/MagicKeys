using System;

namespace MagicKeys
{
public partial class MagicKeys
{
public static string VUFControlGetTextPoint(string Param)
{
string[] FP = Param.Split(",");
string R = ControlGetTextPoint(
P[1]+Convert.ToInt32(FP[0]),
P[2]+Convert.ToInt32(FP[1])
);
Speak(R);
return R;
}

}
}