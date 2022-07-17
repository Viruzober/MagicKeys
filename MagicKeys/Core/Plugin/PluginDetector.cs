using System;
using System.Reflection;
using System.Threading;
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
if (LockPluginDetect == true)
{
continue;
}
foreach (PluginContainer PluginItem in Plugins)
{
foreach(var PluginPointItem in PluginItem.Points)
{
string[] OptionWindowInfo = WinHook(PluginPointItem.WTitle, PluginPointItem.WClass);
if (OptionWindowInfo[0] == null)
{
continue;
}
if (OptionWindowInfo[1] == null)
{
continue;
}
GlobalPluginLoad(PluginItem.PluginName, PluginPointItem);
Coords = GetModuleCoords(CurrentPlugin.Module);
if (Coords != new ModuleCoords())
{
VUILoader(API.GetVUI());
SoundPlay("WindowOpened", false);
SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE|MKC.SWP_NOACTIVATE|MKC.SWP_NOZORDER);
SyncThreads.WaitOne();
WaitPluginClose(OptionWindowInfo[0], OptionWindowInfo[1]);
KeyUnReg();
SyncThreads.ReleaseMutex();
SoundPlay("WindowClosed", false);
ThreadFunc = string.Empty;
PluginClass = null;
PluginClassLoader.Unload();
LUAScript.Globals.Clear();
GC.Collect();
}
}
}
}
}

}
}