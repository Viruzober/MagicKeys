using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFWaitWinClose(String Param)
{
string[] FP = Param.Split("|");
WaitWinClose(FP[0]);
}

}
}