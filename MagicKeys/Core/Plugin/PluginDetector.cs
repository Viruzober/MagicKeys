using System;
using System.Windows.Forms;
using System.Reflection;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{
public static Mutex SyncThreads = new Mutex();

public static void PluginDetector()
{
while(true)
{
Thread.Sleep(Settings.TimeOut);
if (LockPluginDetect == true) continue;
foreach(var Plugin in Plugins)
{
foreach(var Point in Plugin.Points)
{
var CurrentWindow = WinHook(Point.WTitle, Point.WClass);
if (CurrentWindow == (string.Empty, string.Empty)) continue;
if (GetModuleCoords(Point.Module) == new ModuleCoords()) continue;
CurrentPlugin.PluginName = Plugin.PluginName;
CurrentPlugin.WTitle = CurrentWindow.Title;
CurrentPlugin.WClass = CurrentWindow.Class;
CurrentPlugin.PluginClass = Point.PluginClass;
CurrentPlugin.VUIName = Point.StartVUI;
CurrentPlugin.Module = Point.Module;
Coords = GetModuleCoords(Point.Module);
VUILoader(API.GetVUI());
SoundPlay("WindowOpened", false);
SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE|MKC.SWP_NOACTIVATE|MKC.SWP_NOZORDER);
SyncThreads.WaitOne();
WaitPluginClose(CurrentWindow.Title, CurrentWindow.Class);
KeyUnReg();
SyncThreads.ReleaseMutex();
SoundPlay("WindowClosed", false);
ThreadFunc = string.Empty;
PluginClass = null;
PluginClassLoader.Unload();
LUAScript.Globals.Clear();
GC.Collect();
GC.WaitForPendingFinalizers();
}
}
}
}

}
}