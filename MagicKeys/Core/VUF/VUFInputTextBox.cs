using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFInputTextBox(string Param)
{
string[] FP = Param.Split("|");
string ITB = InputTextBox(FP[0], FP[1]);
if (ITB == "0")
{
Speak("Canceled");
return;
}
Clipboard.SetText(ITB);
}

}
}