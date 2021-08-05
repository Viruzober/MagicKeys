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
LUAScript = new Script();
LUAScript.Globals["MK"] = typeof(MagicKeys);
((ScriptLoaderBase)LUAScript.Options.ScriptLoader).IgnoreLuaPathGlobal = true;
string[] path = ((ScriptLoaderBase)LUAScript.Options.ScriptLoader).ModulePaths = new string[] {API.GetVUIPath()+@"\?.lua"};
LUAScript.DoFile(API.GetCurrentScript());
}

}
}