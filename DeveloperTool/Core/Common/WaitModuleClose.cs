using System;
using System.Windows.Forms;
using static MKLib;
using System.Threading;

namespace DeveloperTool
{
public partial class DeveloperTool
{

public static void WaitModuleClose(string Name)
{
while(true)
{
Thread.Sleep(20);
Application.DoEvents();
Coords = GetModuleCoords(ModuleName);
if (Coords == new ModuleCoords())
{
return;
}
if (LockDeveloperTool == true)
{
return;
}
}
}

}
}