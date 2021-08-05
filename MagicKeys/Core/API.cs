using System.IO;
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

public static string GetCurrentScript()
{
if (GetActiveClass() == "lua")
{
return Path.Combine(GetVUIPath(), GetVUI()+".lua");
}
return Path.Combine(GetVUIPath(), GetVUI()+".vuf");
}

public static bool IsSubPlugin()
{
string[] Temp = CurrentPlugin["PluginClass"].Split(".");
if(Temp.Length == 2)
{
return true;
}
return false;
}

public static string GetCurrentVUILoader()
{
return Path.Combine(GetVUIPath(), GetVUI()+"Load.VUI");
}

public static string GetCurrentVUFLoader()
{
return Path.Combine(GetVUIPath(), GetVUI()+"Load.VUF");
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

public static string GetActiveClass()
{
if (API.IsSubPlugin() == true)
{
return GetSubClass();
}
return GetPluginClass();
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
return "None";
}

public static string GetText()
{
return VUIObjects[ActiveObjects[CurrentObject]]["Text"];
}

public static string GetObjectType()
{
return VUIObjects[ActiveObjects[CurrentObject]]["ObjectType"];
}

public static string GetHelp()
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey("Help") == true)
{
return VUIObjects[ActiveObjects[CurrentObject]]["Help"];
}
return "Help not found";
}

public static string GetAutoFunc()
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey("AutoFunc") == true)
{
return VUIObjects[ActiveObjects[CurrentObject]]["AutoFunc"];
}
return null;
}

public static string GetFunc()
{
return VUIObjects[ActiveObjects[CurrentObject]]["Func"];
}

public static string GetParam()
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey("Param") == true)
{
return VUIObjects[ActiveObjects[CurrentObject]]["Param"];
}
return null;
}

}
}