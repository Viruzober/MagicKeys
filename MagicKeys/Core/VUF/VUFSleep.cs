using System;
using static MKLib;
using System.Threading;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFSleep(String Param)
{
Thread.Sleep(Convert.ToInt32(Param));
}

}
}