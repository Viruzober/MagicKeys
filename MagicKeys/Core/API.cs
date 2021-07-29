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
string[] TempPath = GetPluginName().Split("|");
if (TempPath.Length == 2)
{
return Path.Combine("Plugins", TempPath[0], "Plugins", TempPath[1]);
}
return Path.Combine("Plugins", TempPath[0]);
}

public static string GetVUIPath()
{
return Path.Combine(GetPluginPath(), "VUI");
}

public static string GetCurrentVUI()
{
return Path.Combine(GetVUIPath(), GetVUI()+".VUI");
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
return CurrentPlugin["PluginClass"];
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