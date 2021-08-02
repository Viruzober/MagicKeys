using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
namespace MagicKeys
{
public partial class MagicKeys
{
public static void VUFWaitControlClose(String Param)
{
string[] FP = Param.Split(",");
WaitControlClose(P[1]+Convert.ToInt32(FP[0]), P[2]+Convert.ToInt32(FP[1]), FP[2]);
}
}
}