using System;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFSetFocusControlPoint(string Param)
{
string[] FP = Param.Split("|");
SetFocusControlPoint(Convert.ToInt32(FP[0]), Convert.ToInt32(FP[1]));
}

}
}