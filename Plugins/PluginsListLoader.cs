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
if (Ini.IniRead(IVUI, I.ToString(), "BClass") == "None")
{
PluginsList[I].Add("BClass", "None");
}
else
{
PluginsList[I].Add("BClass", GetFullClassName(Ini.IniRead(IVUI, I.ToString(), "BClass")));
}
PluginsList[I].Add("VUI", Ini.IniRead(IVUI, I.ToString(), "VUI"));
PluginsList[I].Add("VUIName", Ini.IniRead(IVUI, I.ToString(), "VUIName"));
PluginsList[I].Add("Module", Ini.IniRead(IVUI, I.ToString(), "Module"));
}
}

}
}