using System;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void HelpForm()
{
string HelpFile = API.GetVUIPath()+API.GetVUI()+".help";
if (File.Exists(HelpFile) == false)
{
MagicKeys.Speak(T._("Help file not found"));
}
else
{
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 1);
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 2);
KeyUnReg();
using HelpForm HF = new HelpForm();
HF.HelpFile = HelpFile;
HF.ShowDialog();
KeyReg();
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
}
}

}
}