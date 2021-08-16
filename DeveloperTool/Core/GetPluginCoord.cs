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
HModule.Add(MKLib.GetForegroundWindow());
HModule.AddRange(MKLib.GetAllWindows(MKLib.GetForegroundWindow()));
foreach(var H in HModule)
{
string ModuleName = MKLib.GetDllName(H);
if (ModuleName.Contains(Module, StringComparison.OrdinalIgnoreCase) == true)
{
Module = ModuleName;
int[] RectCTRL = MKLib.GetWinRect(H);
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2]-1, RectCTRL[3]-1};
return ControlCoord;
}
}
ControlCoord = new int[5] {0, 0, 0, 0, 0};
return ControlCoord;
}

}
}