using System;
using System.Collections.Generic;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static int[] GetPluginCoord()
{
int[] ControlCoord;
List<IntPtr> HModule = new List<IntPtr>();
HModule.Add(MagicKeys.GetForegroundWindow());
HModule.AddRange(MagicKeys.GetAllWindows(MagicKeys.GetForegroundWindow()));
foreach(var H in HModule)
{
string ModuleName = MagicKeys.GetDllName(H);
if (ModuleName.Contains(Module, StringComparison.OrdinalIgnoreCase) == true)
{
Module = ModuleName;
int[] RectCTRL = MagicKeys.GetWinRect(H);
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2]-1, RectCTRL[3]-1};
return ControlCoord;
}
}
ControlCoord = new int[5] {0, 0, 0, 0, 0};
return ControlCoord;
}

}
}