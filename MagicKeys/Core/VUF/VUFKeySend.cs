using System;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFKeySend(string Param)
{
string[] FP = Param.Split(",");
KeySend(FP[0], FP[1], Convert.ToInt32(FP[2]), Convert.ToInt32(FP[3]));
}

}
}