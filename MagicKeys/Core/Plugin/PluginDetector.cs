using System;
using System.Reflection;
using System.Threading;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string[] WH = new string[2];
public static void PluginDetector()
{
while(true)
{
Thread.Sleep(Settings.TimeOut);
if (KeySwitch == 1)
{
continue;
}

foreach (string Item in PluginsList.Keys)
{
WH = WinHook(PluginsList[Item]["WTitle"], PluginsList[Item]["WClass"]);
if (WH[0] == null)
{
continue;
}

if (WH[1] == null)
{
continue;
}

GlobalPluginLoad(Item, WH[0], WH[1]);
Coords = GetModuleCoords(CurrentPlugin["Module"]);
if (Coords != new ModuleCoords())
{
KeyRegInfo.WNDProcHandle = KeyWndProcHandle.Handle;
VUILoader(API.GetVUI());
SoundPlay("WindowOpened", 0);
//SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE|MKC.SWP_NOACTIVATE|MKC.SWP_NOZORDER);
WaitPluginClose(WH[0], WH[1]);
KeyUnReg();
VUIKeys.Clear();
VUIObjects.Clear();
ActiveObjects.Clear();
SoundPlay("WindowClosed", 0);
ThreadFunc = string.Empty;
PluginClass = null;
PluginClassLoader.Unload();
if (API.GetSubClass() != string.Empty && API.GetSubClass() != "MagicKeys")
{
SubClass = null;
SubClassLoader.Unload();
}
LUAScript.Globals.Clear();
GC.Collect();
GC.WaitForPendingFinalizers();
}
CurrentPlugin.Clear();
}
}
}

}
}