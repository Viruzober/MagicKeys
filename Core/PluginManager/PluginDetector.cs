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
for (int I = 1; I <= PluginsList.Count; I++)
{
if (WinActive(PluginsList[I]["WTitle"], PluginsList[I]["WClass"]) == true)
{
GlobalPluginLoad(I);
P = GetPluginCoord();
if (P[0] == 1)
{
VUILoader(API.GetVUI());
if (API.GetWClass() == "#32770")
{
ShowWindow(GetForegroundWindow(), 3);
}
SoundPlay("WindowOpened.ogg", 0);
WinClose(PluginsList[I]["WTitle"], PluginsList[I]["WClass"]);
KeyUnReg();
SoundPlay("WindowClose.ogg", 0);
}
PluginsList.Remove(0);
}
}
}
}

}
}