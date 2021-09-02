using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using static MKLib;

namespace DeveloperTool
{

public partial class DeveloperTool
{

public static Mutex SyncThreads = new Mutex();

public static void ModuleDetector()
{
while(true)
{
Thread.Sleep(20);
if (LockDeveloperTool == true) continue;
if (string.IsNullOrEmpty(ModuleName) == true) continue;
Coords = GetModuleCoords(ModuleName);
if (Coords == new ModuleCoords()) continue;
FixWindow();
CreateDevToolKeys();
SetKeyRegContext(DevKeyRegInfo);
KeyReg();
SoundPlay("WindowOpened");
SyncThreads.WaitOne();
OpenProject();
WaitModuleClose(ModuleName);
KeyUnReg();
LockKeys = false;
SyncThreads.ReleaseMutex();
SoundPlay("WindowClosed");
}
}

}
}