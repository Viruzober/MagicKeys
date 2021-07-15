using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MagicKeys
{
public partial class MagicKeys
{

public static int[] GetPluginCoord()
{
int[] ControlCoord;
List<IntPtr> HModule = GetAllWindows(GetForegroundWindow());
foreach(var H in HModule)
{
 string ModuleName = GetDllName(H);
if (ModuleName.Contains(CurrentPlugin["Module"], StringComparison.OrdinalIgnoreCase) == true)
{
int[] RectCTRL = GetWinRect(H);
SetFocusControlPoint(RectCTRL[0], RectCTRL[1]);
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2]-1, RectCTRL[3]-1};
return ControlCoord;
}
}
ControlCoord = new int[5] {0, 0, 0, 0, 0};
return ControlCoord;
}

}
}