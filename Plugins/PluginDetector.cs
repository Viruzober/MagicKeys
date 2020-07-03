using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public delegate int[] GetP();
public static GetP Mes = GetPos;

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
if (GetPos()[0] == 1)
{
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
PluginsList[0].Add("VUI", PluginsList[ID]["VUI"]);
if (PluginsList[ID].ContainsKey("PluginImg") == true)
{
PluginsList[0].Add("PluginImg", PluginsList[ID]["PluginImg"]);
}
}

}
}