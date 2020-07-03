using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static Dictionary<int, Dictionary<string, string>> PluginsList = new Dictionary<int, Dictionary<string, string>>();

public static void PluginsListLoader()
{
string IVUI = @"VUI\PluginsList.vui";
int PCount = Ini.IniCountSections(IVUI);
for(int I = 1; I <= PCount; I++)
{
PluginsList.Add(I, new Dictionary<string, string>());
PluginsList[I].Add("WTitle", Ini.IniRead(IVUI, I.ToString(), "WTitle"));
PluginsList[I].Add("WClass", Ini.IniRead(IVUI, I.ToString(), "WClass"));
PluginsList[I].Add("PClass", GetFullClassName(Ini.IniRead(IVUI, I.ToString(), "PClass")));
PluginsList[I].Add("VUI", Ini.IniRead(IVUI, I.ToString(), "VUI"));
if (Ini.IniKeyExists(IVUI, I.ToString(), "PluginImg") == true)
{
PluginsList[I].Add("PluginImg", Ini.IniRead(IVUI, I.ToString(), "PluginImg"));
}
}
}

}
}