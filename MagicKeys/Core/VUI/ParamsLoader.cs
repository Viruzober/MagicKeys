using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void ParamsLoader()
{
Count = Ini.IniCountSections(API.GetCurrentVUI());
if (Ini.IniSectionExists(API.GetCurrentVUI(), "Params") == true)
{
if (Ini.IniKeyExists(API.GetCurrentVUI(), "Params", "PluginClass") == true)
{
CurrentPlugin["PluginClass"] = Ini.IniRead(API.GetCurrentVUI(), "Params", "PluginClass");
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), "Params", "Loader") == true)
{
CurrentPlugin["Loader"] = Ini.IniRead(API.GetCurrentVUI(), "Params", "Loader");
}
else
{
CurrentPlugin["Loader"] = "None";
}
Count--;
}
else
{
CurrentPlugin["Loader"] = "None";
}
if (Ini.IniSectionExists(API.GetCurrentVUI(), "Keys") == true) Count--;
}

}
}