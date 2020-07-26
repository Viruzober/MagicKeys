using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void LoadInvoke(List<string> Action, int TimeOut)
{
for(int I = 0 ; I <= Action.Count-1; I++)
{
Thread.Sleep(TimeOut);
string[] FP = Action[I].Split("|", 2);
if (FP[0] == "Func")
{
string[] Param = FP[1].Split("|", 2);
if (Param[1] == "No")
{
InvokeFromString(Param[0]);
continue;
}
InvokeFromString(Param[0], Param[1]);
continue;
}
InvokeFromString("VUF"+FP[0], FP[1], "MagicKeys");
}
}

}
}