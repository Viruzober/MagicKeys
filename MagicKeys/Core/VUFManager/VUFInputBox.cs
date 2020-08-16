using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFInputBox(string Param)
{
string[] FP = Param.Split("|");
string ITB = InputBox(FP[0], FP[1], Convert.ToInt32(FP[2]), Convert.ToInt32(FP[3]));
if (ITB == "0")
{
Speak("Canceled");
return;
}
Clipboard.SetText(ITB);
}

}
}