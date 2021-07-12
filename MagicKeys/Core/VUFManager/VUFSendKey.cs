using System;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFSendKey(string Param)
{
string[] FP = Param.Split("+");
KeySend("Control+O", 100);
}

}
}