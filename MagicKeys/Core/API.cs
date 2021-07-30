using System;
using System.IO;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public class API
{

public static string GetPluginPath()
{
string[] TempPluginName = CurrentPlugin["PluginName"].Split(".");
if (TempPluginName.Length == 2)
{
return Path.Combine("Plugins", TempPluginName[0], "Subplugins", TempPluginName[1]);
}
return Path.Combine("Plugins", TempPluginName[0]);
}

public static string GetVUIPath()
{
return Path.Combine(GetPluginPath(), "VUI");
}

public static string GetCurrentVUI()
{
return Path.Combine(GetVUIPath(), GetVUI()+".VUI");
}

public static string GetCurrentVUF()
{
return Path.Combine(GetVUIPath(), GetVUI()+".VUF");
}

public static string GetImgPath()
{
return Path.Combine(GetPluginPath(), "Images");
}

public static string GetModulePath()
{
return Path.Combine(GetPluginPath(), GetPluginName()+".dll");
}

public static string GetWTitle()
{
return CurrentPlugin["WTitle"];
}

public static string GetWClass()
{
return CurrentPlugin["WClass"];
}

public static string GetPluginClass()
{
string[] TempClass = CurrentPlugin["PluginClass"].Split(".");
if (TempClass.Length == 2)
{
return TempClass[0];
}
return TempClass[0];
}

public static string GetSubClass()
{
string[] TempClass = CurrentPlugin["PluginClass"].Split(".");
if (TempClass.Length == 2)
{
return TempClass[1];
}
return string.Empty;
}

public static string GetVUI()
{
return CurrentPlugin["VUI"];
}

public static string GetVUIExt()
{
return CurrentPlugin["VUI"]+".vui";
}

public static string GetPluginName()
{
string[] TempPluginName = CurrentPlugin["PluginName"].Split(".");
if (TempPluginName.Length == 2)
{
return TempPluginName[1];
}
return CurrentPlugin["PluginName"];
}

public static string GetModule()
{
return CurrentPlugin["Module"];
}

public static string GetLoader()
{
if (CurrentPlugin.ContainsKey("Loader") == true)
{
return CurrentPlugin["Loader"];
}
else
{
return null;
}
}

public static string GetText()
{
return VUIObjects[ActiveObjects[Section]]["Text"];
}

public static string GetObjectType()
{
return VUIObjects[ActiveObjects[Section]]["ObjectType"];
}

public static string GetHelp()
{
return VUIObjects[ActiveObjects[Section]]["Help"];
}

public static string GetAutoFunc()
{
if (VUIObjects[ActiveObjects[Section]].ContainsKey("AutoFunc") == true)
{
return VUIObjects[ActiveObjects[Section]]["AutoFunc"];
}
return null;
}

public static string GetFunc()
{
return VUIObjects[ActiveObjects[Section]]["Func"];
}

public static string GetParam()
{
if (VUIObjects[ActiveObjects[Section]].ContainsKey("Param") == true)
{
return VUIObjects[ActiveObjects[Section]]["Param"];
}
return null;
}

public static string GetObjectKey()
{
if (VUIObjects[ActiveObjects[Section]].ContainsKey("Key") == true)
{
return VUIObjects[ActiveObjects[Section]]["Key"];
}
return null;
}

}
}