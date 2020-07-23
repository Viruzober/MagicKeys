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