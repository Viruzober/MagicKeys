using System;
using System.Reflection;
using System.Runtime.Loader;
using System.Windows.Forms;
using System.IO;

namespace MagicKeys
{
public partial class MagicKeys
{

public static MagicKeys MKOBJ = new MagicKeys();
public static object PluginClass = null;
public static CustomAssemblyLoadContext ASMLoader = new CustomAssemblyLoadContext();

public static void GetPluginType()
{
string ModulePath = string.Empty;
ASMLoader = new CustomAssemblyLoadContext();
            try
            {
if (API.GetPluginClass() == "MagicKeys")
{
PluginClass = MKOBJ.GetType();
return;
}
ModulePath = Path.Combine(Directory.GetCurrentDirectory(), API.GetModulePath());
Assembly PluginClasASM = ASMLoader.LoadFromAssemblyPath(ModulePath);
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