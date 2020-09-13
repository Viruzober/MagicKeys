using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFWaitControlClosePoint(String Param)
{
string[] FP = Param.Split("|");
WaitControlClosePoint(Convert.ToInt32(FP[0]), Convert.ToInt32(FP[1]), FP[2]);
}

}
}