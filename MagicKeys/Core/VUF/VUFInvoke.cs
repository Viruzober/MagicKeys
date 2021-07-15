using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFInvoke(List<string> Action, int TimeOut = 0)
{
for(int I = 0 ; I <= Action.Count-1; I++)
{
if (TimeOut != 0) Thread.Sleep(TimeOut);
string[] FP = Action[I].Split("|", 2);
if (FP[0] == "Func")
{
string[] Param = FP[1].Split("|", 2);
if (Param.Length == 1)
{
InvokeFromString(Param[0]);
continue;
}
InvokeFromString(Param[0], Param[1]);
continue;
}
InvokeFromString("VUF"+FP[0], FP[1]);
}
}

}
}