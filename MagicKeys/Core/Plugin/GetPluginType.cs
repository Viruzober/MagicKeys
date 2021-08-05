using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace MagicKeys
{

public partial class MagicKeys
{

public static MagicKeys MKOBJ = new MagicKeys();
public static object PluginClass = new object();
public static CustomAssemblyLoadContext PluginClassLoader = new CustomAssemblyLoadContext();
public static void GetPluginType()
{
if (API.GetSubClass() != string.Empty)
{
return;
}

string ModulePath = string.Empty;
PluginClassLoader = new CustomAssemblyLoadContext();
try
{
if (API.GetPluginClass() == "lua")
{
LUAInit();
return;
}
if (API.GetPluginClass() == "MagicKeys")
{
PluginClass = MKOBJ.GetType();
return;
}
ModulePath = Path.Combine(Directory.GetCurrentDirectory(), API.GetModulePath());
Assembly PluginClasASM = PluginClassLoader.LoadFromAssemblyPath(ModulePath);
var ClassType = PluginClasASM.GetType("MagicKeys."+API.GetPluginClass());
PluginClass =  Activator.CreateInstance(ClassType);
}
catch(Exception)
{
MKDebugForm("FileNotFound|"+ModulePath);
return;
}
}
}

public class CustomAssemblyLoadContext : AssemblyLoadContext
{

public CustomAssemblyLoadContext() : base(isCollectible: true)
{ }
protected override Assembly Load(AssemblyName assemblyName)
{
return null;
}

}
}