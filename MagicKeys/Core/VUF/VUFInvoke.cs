using System.Collections.Generic;
using System.Threading;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFInvoke(List<string> Funcs, List<string> Params, int TimeOut = 0, bool AudoFunc = false)
{
string R = null;
for(int I = 0 ; I <= Funcs.Count-1; I++)
{
if (TimeOut != 0)
{
Thread.Sleep(TimeOut);
}

if (Funcs[I] == "Func")
{
string[] Param = Params[I].Split(",", 2);
if (Param.Length == 1)
{
R = InvokeFromString(Param[0]);
continue;
}
R = InvokeFromString(Param[0], Param[1]);
continue;
}
R = InvokeFromString("VUF"+Funcs[I], Params[I]);
}
if (AudoFunc == true)
{
return R;
}
else
{
return string.Empty;
}
}

}
}