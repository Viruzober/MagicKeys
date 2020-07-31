using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFProgressState(string Param)
{
string[] FP = Param.Split("|");
ProgressState(
FP[0],
Convert.ToInt32(FP[1]),
Convert.ToInt32(FP[2]),
Convert.ToInt32(FP[3]),
Convert.ToInt32(FP[4])
);
}

}
}