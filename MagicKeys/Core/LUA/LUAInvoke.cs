using MoonSharp.Interpreter;


namespace MagicKeys
{
[MoonSharpUserData]
public partial class MagicKeys
{

public static string LUAInvoke(string Func, string Param = null)
{
DynValue Resulte;
if (Param == null)
{
Resulte = LUAScript.Call(LUAScript.Globals[Func]);
}
else
{
Resulte = LUAScript.Call(LUAScript.Globals[Func], Param);
}
return Resulte.String;
}

}
}