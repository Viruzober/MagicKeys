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

public static void PluginDetector()
{
string[] WH = new string[2];
while(true)
{
Thread.Sleep(TimeOut);
if (KeySwitch == 1)
{
continue;
}
foreach(string Item in PluginsList.Keys)
{
if (Item == "Info")
{
continue;
}
WH = WinHook(PluginsList[Item]["WTitle"], PluginsList[Item]["WClass"]);
if (WH[0] != null)
{
GlobalPluginLoad(Item, WH[0], WH[1]);
P = GetPluginCoord();
if (P[0] == 1)
{
VUILoader(API.GetVUI());
SoundPlay("WindowOpened", 0);
WinClose(WH[0], WH[1]);
KeyUnReg();
SoundPlay("WindowClosed", 0);
}
SubPath = string.Empty;
CurrentPlugin.Clear();
}
}
}
}

}
}