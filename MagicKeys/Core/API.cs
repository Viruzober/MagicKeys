using System;
using System.IO;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public class API
{

public static string GetVUIPath()
{
return @"Plugins\"+GetPluginName()+@"\VUI\";
}

public static string GetImgPath()
{
return @"Plugins\"+GetPClass()+@"\Images\";
}

public static string GetModulePath()
{
if (File.Exists(@"Plugins\"+GetPluginName()+@"\"+GetPluginName()+".dll") == true)
{
return @"Plugins\"+GetPluginName()+@"\"+GetPluginName()+".dll";
}
return null;
}

public static string GetWTitle()
{
return CurrentPlugin["WTitle"];
}

public static string GetWClass()
{
return CurrentPlugin["WClass"];
}

public static string GetPClass()
{
return CurrentPlugin["PClass"];
}

public static string GetBClass()
{
return CurrentPlugin["BClass"];
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

public static string GetActiveKey()
{
return CurrentPlugin["ActiveKey"];
}

public static string GetLoad()
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