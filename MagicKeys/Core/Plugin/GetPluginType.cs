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
string ModulePath = string.Empty;
PluginClassLoader = new CustomAssemblyLoadContext();
try
{
if (API.GetPluginClass() == "lua")
{
LUAInit();
return;
}
ModulePath = Path.Combine(Directory.GetCurrentDirectory(), API.GetModulePath());
Assembly PluginClasASM = PluginClassLoader.LoadFromAssemblyPath(ModulePath);
var ClassType = PluginClasASM.GetType("MagicKeys."+API.GetPluginClass());
PluginClass =  Activator.CreateInstance(ClassType);
if (PluginClass.GetType().GetMethod(API.GetVUI()+"Loader") != null)
{
SystemInvoke(API.GetVUI()+"Loader");
}
}
catch(Exception)
{
MKDebugForm("File not found "+ModulePath);
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