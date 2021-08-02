using System;
namespace MagicKeys
{
public partial class MagicKeys
{
public static string VUFCheckStateImg(string Param)
{
string[] FP = Param.Split(",");
string R = CheckStateImg(
FP[0],
P[1]+Convert.ToInt32(FP[1]),
P[2]+Convert.ToInt32(FP[2]),
P[1]+Convert.ToInt32(FP[3]),
P[2]+Convert.ToInt32(FP[4])
);
Speak(R);
return R;
}
}
}