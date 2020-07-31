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
if (WinActive(PluginsList[Item]["WTitle"], PluginsList[Item]["WClass"]) == true)
{
GlobalPluginLoad(Item);
P = GetPluginCoord();
if (P[0] == 1)
{
VUILoader(API.GetVUI());
SoundPlay("WindowOpened.ogg", 0);
WinClose(PluginsList[Item]["WTitle"], PluginsList[Item]["WClass"]);
KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
SubPath = "";
CurrentPlugin.Clear();
}
}
}
}

}
}