using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string CheckStatePixel(string Param)
{
string[] FP = Param.Split("|");
string R = CheckStatePixel(
FP[0],
P[1]+Convert.ToInt32(FP[1]),
P[2]+Convert.ToInt32(FP[2])
);
Speak(R);
return R;
}

}
}