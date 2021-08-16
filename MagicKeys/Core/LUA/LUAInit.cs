using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Loaders;


namespace MagicKeys
{

public partial class MagicKeys
{

public static Script LUAScript = new Script();
public static void LUAInit()
{
UserData.RegisterType<MagicKeys>();
UserData.RegisterType<ModuleCoords>();
UserData.RegisterType(typeof(MKLib));
LUAScript = new Script();
LUAScript.Globals["MK"] = typeof(MagicKeys);
LUAScript.Globals["MKLib"] = typeof(MKLib);
((ScriptLoaderBase)LUAScript.Options.ScriptLoader).IgnoreLuaPathGlobal = true;
string[] path = ((ScriptLoaderBase)LUAScript.Options.ScriptLoader).ModulePaths = new string[] {API.GetVUIPath()+@"\?.lua"};
LUAScript.DoFile(API.GetCurrentScript());
}

}
}