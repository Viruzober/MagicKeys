using System;
using System.Collections.Generic;

namespace MagicKeys
{
public partial class MagicKeys
{
public static int[] GetPluginCoord()
{
int[] ControlCoord;
List<IntPtr> HModule = new List<IntPtr>();
HModule.Add(GetForegroundWindow());
HModule.AddRange(GetAllWindows(GetForegroundWindow()));
foreach(var H in HModule)
{
string ModuleName = GetDllName(H);
if (ModuleName.Contains(CurrentPlugin["Module"], StringComparison.OrdinalIgnoreCase) == true)
{
int[] RectCTRL = GetWinRect(H);
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2]-1, RectCTRL[3]-1};
return ControlCoord;
}
}
ControlCoord = new int[5] {0, 0, 0, 0, 0};
return ControlCoord;
}

}
}