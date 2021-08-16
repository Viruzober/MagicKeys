using System;
using System.Collections.Generic;

public record ModuleCoords
{
public int X;
public int Y;
public int W;
public int H;
}

public static partial class MKLib
{

public static ModuleCoords GetModuleCoords(string HookModuleName)
{
List<IntPtr> HModule = new List<IntPtr>();
HModule.Add(GetForegroundWindow());
HModule.AddRange(GetAllWindows(GetForegroundWindow()));
foreach(var H in HModule)
{
string ModuleName = GetDllName(H);
if (ModuleName.Contains(HookModuleName, StringComparison.OrdinalIgnoreCase) == true)
{
int[] RectCTRL = GetWinRect(H);
return new ModuleCoords {X = RectCTRL[0], Y = RectCTRL[1], W = RectCTRL[2], H = RectCTRL[3]};
}
}
return new ModuleCoords();
}

}