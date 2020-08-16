using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class DeveloperTool
{
public static int[] ControlCoord;
public static int[] GetPluginCoord()
{
IntPtr Handle = MagicKeys.GetForegroundWindow();
int[] RC = MagicKeys.GetWinRect(Handle);
for (int X = RC[0]; X < RC[2]; X+=50)
{
for (int Y = RC[1]; Y < RC[3]; Y+=150)
{
IntPtr HModule = MagicKeys.GetWinPointHandle(X, Y);
string ModuleName = MagicKeys.GetDllName(HModule);
if (ModuleName.Contains(Module, StringComparison.OrdinalIgnoreCase) == true)
{
Module = ModuleName;
int[] RectCTRL = MagicKeys.GetWinRect(MagicKeys.GetWinPointHandle(X, Y));
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2], RectCTRL[3]};
return ControlCoord;
}
}
}
ControlCoord = new int[5] {0, 0, 0, 0, 0};
return ControlCoord;
}

}
}