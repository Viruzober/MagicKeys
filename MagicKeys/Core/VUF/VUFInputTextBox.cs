using System;
using static MKLib;
using System.Windows.Forms;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFInputTextBox(string Param)
{
string[] FP = Param.Split(",");
string ITB = InputTextBox(FP[0], FP[1], FP.Length == 3?Convert.ToBoolean(FP[2]):false);
if (ITB == null)
{
Speak("Canceled");
return;
}
Clipboard.SetText(ITB);
}

}
}