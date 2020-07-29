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
public static Dictionary<string, string> CurrentPlugin = new Dictionary<string, string>();
public static void GlobalPluginLoad(string Item)
{
CurrentPlugin.Add("WTitle", PluginsList[Item]["WTitle"]);
CurrentPlugin.Add("WClass", PluginsList[Item]["WClass"]);
CurrentPlugin.Add("PClass", PluginsList[Item]["PClass"]);
CurrentPlugin.Add("BClass", PluginsList[Item]["BClass"]);
CurrentPlugin.Add("VUI", PluginsList[Item]["VUI"]);
CurrentPlugin.Add("PluginName", PluginsList[Item]["PluginName"]);
CurrentPlugin.Add("Module", PluginsList[Item]["Module"]);
}

}
}