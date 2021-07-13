/*using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class MagicKeys
{
public static int[] ControlCoord;
public static string ModuleName;
public static IntPtr HModule;
public static int[] GetPluginCoord()
{
IntPtr Handle = GetForegroundWindow();
int[] RC = GetWinRect(Handle);
for (int X = RC[0]; X < RC[2]; X+=200)
{
for (int Y = RC[1]; Y < RC[3]; Y+=200)
{
HModule = GetWinPointHandle(X, Y);
 ModuleName = GetDllName(HModule);
if (ModuleName.Contains(CurrentPlugin["Module"], StringComparison.OrdinalIgnoreCase) == true)
{
int[] RectCTRL = GetWinRect(GetWinPointHandle(X, Y));
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2]-1, RectCTRL[3]-1};
return ControlCoord;
}
}
}
ControlCoord = new int[5] {0, 0, 0, 0, 0};
return ControlCoord;
}

}
}*/