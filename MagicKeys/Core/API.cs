using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public class API
{

public static string GetPluginPath()
{
return Path.Combine("Plugins", CurrentPlugin.PluginName);
}

public static string GetVUIPath()
{
return Path.Combine(GetPluginPath(), "VUI");
}

public static string GetLUAPath()
{
return Path.Combine(GetPluginPath(), "LUA");
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
return CurrentPlugin.WTitle;
}

public static string GetWClass()
{
return CurrentPlugin.WClass;
}

public static string GetPluginClass()
{
return CurrentPlugin.PluginClass;
}

public static string GetVUI()
{
return CurrentPlugin.VUIName;
}

public static string GetPluginName()
{
return CurrentPlugin.PluginName;
}

public static string GetModule()
{
return CurrentPlugin.Module;
}

public static string GetNameCurrentObject()
{
return VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Name;
}

public static string GetText()
{
return VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Text;
}

public static string GetObjectType()
{
return VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Type;
}

public static string GetHelp()
{
if (VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Help != String.Empty)
{
return VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Help;
}
return "Help not found";
}

public static bool FuncIsBackground(string TypeFunc)
{
bool IsBackgroundFunc = false;
if (TypeFunc == "Func")
{
IsBackgroundFunc = VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Function.Background;
}
if (TypeFunc == "AutoFunc")
{
IsBackgroundFunc = VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].AutoFunction.Background;
}
return IsBackgroundFunc;
}

public static string GetFunc(string TypeFunc)
{
string FuncName = string.Empty;
if (TypeFunc == "Func")
{
FuncName = VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Function.Name;
}
if (TypeFunc == "AutoFunc")
{
FuncName = VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].AutoFunction.Name;
}
return FuncName;
}

        public static string GetParam(string TypeParam)
{
if (TypeParam == "Func")
{
if (VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Function.Param == String.Empty) return null;
string TempParamInfo = VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].Function.Param;
return TempParamInfo;
}

if (TypeParam == "AutoFunc")
{
if (VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].AutoFunction.Param == String.Empty) return null;
string TempParamInfo = VisibleVUIObjects[CurrentPlugin.CurrentVUIObjectNumber].AutoFunction.Param;
return TempParamInfo;
}
return null;
}

}
}