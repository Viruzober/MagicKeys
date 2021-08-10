using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
return null;
}

public static string GetNameCurrentObject()
{
if (ActiveObjects.Any() == true)
{
return ActiveObjects[CurrentObject];
}
return null;
}

public static string GetText()
{
return VUIObjects[ActiveObjects[CurrentObject]]["Text"];
}

public static string GetObjectType()
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey("ObjectType") == true)
{
return VUIObjects[ActiveObjects[CurrentObject]]["ObjectType"];
}
return string.Empty;
}

public static string GetHelp()
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey("Help") == true)
{
return VUIObjects[ActiveObjects[CurrentObject]]["Help"];
}
return "Help not found";
}

public static bool FuncIsBackground(string TypeFunc)
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey(TypeFunc) == true)
{
string[] Temp = VUIObjects[ActiveObjects[CurrentObject]][TypeFunc].Split(",", 2);
if (Temp[0] == "Background")
{
return true;
}
return false;
}
return false;
}

public static string GetFunc(string TypeFunc)
{
try
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey(TypeFunc) == true)
{
string[] Temp = VUIObjects[ActiveObjects[CurrentObject]][TypeFunc].Split(",", 2);
if (Temp[0] == "Background")
{
return Temp[1].Split(",", 2)[0].Trim();
}
return Temp[0].Split(",", 2)[0].Trim();
}
return null;
}
catch(Exception)
        {
        return null;
}
        }

        public static string GetParam(string TypeParam)
{
try
{
if (VUIObjects[ActiveObjects[CurrentObject]].ContainsKey(TypeParam) == true)
{
string[] Temp = VUIObjects[ActiveObjects[CurrentObject]][TypeParam].Split(",");
if (Temp[0] == "Background")
{
return Temp[1].Split(",", 2)[1].Trim();
}
return Temp[1].Trim();
}
return null;
}
catch(Exception)
{
return null;
}
}

}
}