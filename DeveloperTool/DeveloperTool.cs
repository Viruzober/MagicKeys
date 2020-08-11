using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static Menu HM;

static void Main()
{
HM = new Menu();
MagicKeys.Speak("DeveloperTool is ready");
MagicKeys.RegisterHotKey(HM.Handle, 0, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F1);
MagicKeys.RegisterHotKey(HM.Handle, 1, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F2);
Application.Run();
}

}
}