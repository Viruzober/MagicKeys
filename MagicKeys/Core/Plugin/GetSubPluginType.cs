using System;
using System.Reflection;
using System.Runtime.Loader;
using System.Windows.Forms;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{

public static object SubClass = new object();
public static CustomAssemblyLoadContext SubClassLoader = new CustomAssemblyLoadContext();

public static void GetSubPluginType()
{
string ModulePath = string.Empty;
SubClassLoader = new CustomAssemblyLoadContext();
            try
            {
if (API.GetSubClass() == string.Empty | API.GetSubClass() == "MagicKeys")
{
SubClass = MKOBJ.GetType();
return;
}
ModulePath = Path.Combine(Directory.GetCurrentDirectory(), API.GetModulePath());
Assembly SubClasASM = SubClassLoader.LoadFromAssemblyPath(ModulePath);
var ClassType = SubClasASM.GetType("MagicKeys."+API.GetSubClass());
SubClass =  Activator.CreateInstance(ClassType);
}
catch(Exception)
{
MKDebugForm("FileNotFound|"+ModulePath);
return;
}
}

}
}