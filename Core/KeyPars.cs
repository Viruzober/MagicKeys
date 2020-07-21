using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string KeyPars(int Mod)
{
if (Mod == 1) return "Alt";
if (Mod == 2) return "Ctrl";
if (Mod == 3) return "Ctrl+Alt";
if (Mod == 4) return "Shift";
if (Mod == 5) return "Alt+Shift";
if (Mod == 6) return "Ctrl+Shift";
if (Mod == 7) return "Ctrl+Shift+Alt";
if (Mod == 8) return "Win";
if (Mod == 9) return "Alt+Win";
if (Mod == 10) return "Ctrl+Win";
if (Mod == 11) return "Ctrl+Alt+Win";
if (Mod == 12) return "Win+Shift";
if (Mod == 13) return "Alt+Win+Shift";
if (Mod == 14) return "Ctrl+Win+Shift";
if (Mod == 15) return "Ctrl+Win+Alt+Shift";
return "Null";
}

}
}