using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{
public static string[] WH = new string[2];
public static void PluginDetector()
{
while(true)
{
//
Thread.Sleep(TimeOut);
if (KeySwitch == 1) continue;
foreach(string Item in PluginsList.Keys)
{
WH = WinHook(PluginsList[Item]["WTitle"], PluginsList[Item]["WClass"]);
if (WH[0] == null) continue;
if (WH[1] == null) continue;
GlobalPluginLoad(Item, WH[0], WH[1]);
P = GetPluginCoord();
if (P[0] == 1)
{
VUILoader(API.GetVUI());
SoundPlay("WindowOpened", 0);
SetWindowPos(GetForegroundWindow(), 0, 50, 50, 0, 0, MKC.SWP_NOSIZE|MKC.SWP_NOACTIVATE|MKC.SWP_NOZORDER);
WinClose(WH[0], WH[1]);
KeyUnReg();
SoundPlay("WindowClosed", 0);
PClass = null;
BClass = null;
}
SubPath = string.Empty;
CurrentPlugin.Clear();
}
}
}

}
}