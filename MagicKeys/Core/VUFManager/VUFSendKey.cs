using System;
using System.Windows.Forms;
using System.Threading;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFSendKey(string Param)
{
//MouseClick("Left", P[1]+10, P[2]+10, 1, 0, 0, 10);
string[] FP = Param.Split("+");
KeySend("Text", "Привет как дела?😀👦🏽", 100);
}

}
}