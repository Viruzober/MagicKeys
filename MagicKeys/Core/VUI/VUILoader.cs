using static MKLib;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUILoader(string File)
{
KeyUnReg();
VUIKeysFunctions.Clear();
AllVUIObjects.Clear();
VisibleVUIObjects.Clear();
ThreadFunc = string.Empty;
SoundPlay("ChangeVUI", false);
CurrentPlugin.VUIName = File;
string[] AllVUIObjectsNames = Ini.IniReadSections(API.GetCurrentVUI()).Where(ParamSections => ParamSections != "Keys").ToArray();
foreach(var ObjectName in AllVUIObjectsNames)
{
AllVUIObjects.Add(VUIObjectParser(ObjectName));
}
VUIObjectsUpdate(true);
GetPluginType();
KeyLoader();
KeyReg();
SoundPlay("PluginDetect", false);
}

}
}