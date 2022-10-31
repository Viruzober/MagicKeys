using System;
using System.Collections.Generic;
using System.Linq;
public static partial class MKLib
{

public static List<string> GetAllModules()
{
List<IntPtr> HModule = new List<IntPtr>();
HModule.AddRange(GetAllWindows(GetForegroundWindow()));
List<string> Modules = new List<string>();
foreach(var Handle in HModule)
{
Modules.Add(GetModuleName(Handle));
}
return Modules.Distinct().ToList();
}

}