using System;
using Microsoft.Collections.Extensions;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUILoader(string File)
{
KeyUnReg();
VUIKeys.Clear();
VUIObjects.Clear();
ActiveObjects.Clear();
SoundPlay("ChangeVUI", 0);
CurrentPlugin["VUI"] = File;
ParamsLoader();
string[] AllVUIObjects = Ini.IniReadSections(API.GetCurrentVUI()).Where(ParamSections => ParamSections != "Params" && ParamSections != "Keys").ToArray();
foreach(var ObjectName in AllVUIObjects)
{
VUIObjects.Add(ObjectName, new OrderedDictionary<string, string>());
VUIObjects.GetValueOrDefault(ObjectName).Add("Active", "true");
VUIObjects.GetValueOrDefault(ObjectName).Add("Text", Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Text"));
VUIObjects.GetValueOrDefault(ObjectName).Add("ObjectType", Ini.IniRead(API.GetCurrentVUI(), ObjectName, "ObjectType"));
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "Help") == true)
{
VUIObjects.GetValueOrDefault(ObjectName).Add("Help", Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Help"));
}
else
{
VUIObjects.GetValueOrDefault(ObjectName).Add("Help", "Help not found");
}
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "AutoFunc") == true)
{
VUIObjects.GetValueOrDefault(ObjectName).Add("AutoFunc", Ini.IniRead(API.GetCurrentVUI(), ObjectName, "AutoFunc"));
}
VUIObjects.GetValueOrDefault(ObjectName).Add("Func", Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Func"));
if (Ini.IniKeyExists(API.GetCurrentVUI(), ObjectName, "Param") == true)
{
VUIObjects.GetValueOrDefault(ObjectName).Add("Param", Ini.IniRead(API.GetCurrentVUI(), ObjectName, "Param"));
}
}
VUIObjectsUpdate(true);
GetPluginType();
VUIPluginLoad();
KeyLoader();
KeyReg();
SoundPlay("PluginDetect", 0);
}

}
}