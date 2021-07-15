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
public static void GlobalPluginLoad(string Item, string WTitle, string WClass)
{
CurrentPlugin.Add("WTitle", WTitle);
CurrentPlugin.Add("WClass", WClass);
CurrentPlugin.Add("PClass", PluginsList[Item]["PClass"]);
CurrentPlugin.Add("BClass", PluginsList[Item]["BClass"]);
CurrentPlugin.Add("VUI", PluginsList[Item]["VUI"]);
CurrentPlugin.Add("PluginName", PluginsList[Item]["PluginName"]);
CurrentPlugin.Add("Module", PluginsList[Item]["Module"]);
}

}
}