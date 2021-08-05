using MoonSharp.Interpreter;


namespace MagicKeys
{
[MoonSharpUserData]
public partial class MagicKeys
{

public static string LUAInvoke(string Func, string Param = null, bool AutoFunc = false)
{
DynValue Resulte;
if (AutoFunc == true)
{
Resulte = LUAScript.Call(LUAScript.Globals[Func]);
return Resulte.String;
}
if (Param == null)
{
LUAScript.Call(LUAScript.Globals[Func]);
}
else
{
LUAScript.Call(LUAScript.Globals[Func], Param);
}
return string.Empty;
}

}
}