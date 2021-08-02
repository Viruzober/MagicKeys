using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace MagicKeys
{
public partial class MagicKeys
{
public static void VUIPluginLoad()
{
if (API.GetLoader() == "Code")
{
InvokeFromString(API.GetVUI()+"Loader");
return;
}
else if (API.GetLoader() == "VUF")
{
if (File.Exists(API.GetCurrentVUILoader()) == false)
{
return;
}
List<string> LoaderSections = Ini.IniReadSections(API.GetCurrentVUILoader());
foreach(var LoadItem in LoaderSections)
{
List<string> LoadValues = Ini.IniReadValues(API.GetCurrentVUILoader(), LoadItem);
string[] Trigger = LoadValues[0].Split(",");
List<string> Funcs = Ini.IniReadKeys(API.GetCurrentVUFLoader(), LoadItem);
List<string> Params = Ini.IniReadValues(API.GetCurrentVUFLoader(), LoadItem);
if (Trigger[0] == "Img")
{
if (ImgSearch(Trigger[1], true)[0] == Convert.ToInt32(Convert.ToBoolean(Trigger[2])))
{
VUFInvoke(Funcs, Params, Convert.ToInt32(LoadValues[1]));
}
}
else if(Trigger[0] == "VUI")
{
if (Trigger[1] == API.GetVUI())
{
VUFInvoke(Funcs, Params, Convert.ToInt32(LoadValues[1]));
}
}
}
}
}
}
}