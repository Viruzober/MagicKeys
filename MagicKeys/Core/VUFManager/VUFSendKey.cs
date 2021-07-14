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
string STR = "Когда настанет 2️⃣189 год, все кыки👱‍♀️ превратятся в👵 или просто дупу🐧, но пока их нет 🤬здесь должна быть буква ять💔";
TestKeySend("Text", STR, 100);
}

}
}