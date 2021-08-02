using System;
using Microsoft.Collections.Extensions;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;

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
CurrentPlugin.Remove("Loader");
SoundPlay("ChangeVUI", 0);
CurrentPlugin["VUI"] = File;
ParamsLoader();
string[] AllVUIObjects = Ini.IniReadSections(API.GetCurrentVUI()).Where(ParamSections => ParamSections != "Params" && ParamSections != "Keys").ToArray();
CountObjects = AllVUIObjects.Length-1;
foreach(var ObjectName in AllVUIObjects)
{
VUIObjects.Add(ObjectName, new OrderedDictionary<string, string>());
List<string> Keys = Ini.IniReadKeys(API.GetCurrentVUI(), ObjectName);
List<string> Values = Ini.IniReadValues(API.GetCurrentVUI(), ObjectName);
VUIObjects.GetValueOrDefault(ObjectName).Add("Active", "true");
for(int I = 0; I <= Keys.Count-1; I++)
{
try
{
if(Keys[I] == "" || Values[I] == "") throw new IndexOutOfRangeException();
VUIObjects.GetValueOrDefault(ObjectName).Add(Keys[I], Values[I]);
}
catch(IndexOutOfRangeException)
{
MKDebugForm("VUILoader|"+API.GetCurrentVUI()+"|"+ObjectName);
}
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