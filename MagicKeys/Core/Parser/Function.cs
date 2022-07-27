using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static MKLib;

namespace MagicKeys
{
public partial class MagicKeys
{

public static FunctionContainer FunctionParser(string ParsString)
{
FunctionContainer TempFunctionContainer = new FunctionContainer();
string TempFunctionStr = ParsString;
if (ParsString.Split("|")[0].Trim() == "Background")
{
TempFunctionContainer.Background = true;
TempFunctionContainer.Name = ParsString.Split("|")[1].Split(":")[0];
TempFunctionStr = ParsString.Split("|")[1];
}
else
{
TempFunctionContainer.Name = ParsString.Split(":")[0];
}
if (TempFunctionStr.Split(":").Length > 1)
{
TempFunctionContainer.Param = TempFunctionStr.Split(":", 2)[1];
}
return TempFunctionContainer;
}

}
}