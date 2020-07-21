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
P = GetPos();
if (P[0] == 1)
{
VUILoader(API.GetVUI());
if (API.GetWClass() == "#32770")
{
ShowWindow(GetForegroundWindow(), 3);
}
InvokeFromString("PluginLoad");
SoundPlay("WindowOpened.ogg", 0);
WinClose(PluginsList[I]["WTitle"], PluginsList[I]["WClass"]);
InvokeFromString("PluginUnLoad");
SoundPlay("WindowClose.ogg", 0);
}
PluginsList.Remove(0);
}
}
}
}

public static void GlobalPluginLoad(int ID)
{
PluginsList.Add(0, new Dictionary<string, string>());
PluginsList[0].Add("WTitle", PluginsList[ID]["WTitle"]);
PluginsList[0].Add("WClass", PluginsList[ID]["WClass"]);
PluginsList[0].Add("PClass", PluginsList[ID]["PClass"]);
PluginsList[0].Add("BClass", PluginsList[ID]["BClass"]);
PluginsList[0].Add("VUI", PluginsList[ID]["VUI"]);
PluginsList[0].Add("VUIName", PluginsList[ID]["VUIName"]);
PluginsList[0].Add("Module", PluginsList[ID]["Module"]);
}

}
}