using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class API
{

public static string GetWTitle()
{
return PluginsList[0]["WTitle"];
}

public static string GetWClass()
{
return PluginsList[0]["WClass"];
}

public static string GetPClass()
{
return PluginsList[0]["PClass"];
}

public static string GetBClass()
{
return PluginsList[0]["BClass"];
}

public static string GetVUI()
{
return PluginsList[0]["VUI"];
}

public static string GetVUIName()
{
return PluginsList[0]["VUIName"];
}

public static string GetModule()
{
return PluginsList[0]["Module"];
}

public static string GetActiveKey()
{
return PluginsList[0]["ActiveKey"];
}

public static string GetLoad()
{
if (PluginsList[0].ContainsKey("Load") == true)
{
return PluginsList[0]["Load"];
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

public static string GetOpjectType()
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