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
string HelpFile = @"VUI\"+PluginsList[0]["VUI"];
if (File.Exists(HelpFile.Substring(0, HelpFile.Length - 3)+"help") == false)
{
MagicKeys.Speak("Файл справки не найден");
}
else
{
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 1);
MagicKeys.UnregisterHotKey(MagicKeys.HM.Handle, 2);
InvokeFromString("KeyUnReg");
HelpForm HF = new HelpForm();
HF.HelpFile = HelpFile;
HF.ShowDialog();
InvokeFromString("KeyReg");
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 2, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F3);
MagicKeys.RegisterHotKey(MagicKeys.HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
}
}

}
}