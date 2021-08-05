using System.IO;

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
KeyUnReg();
using HelpForm HF = new HelpForm();
HF.HelpFile = HelpFile;
HF.ShowDialog();
KeyReg();
}
}

}
}