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
if (ParsString.Split("|")[0].Trim() == "Background")
{
TempFunctionContainer.Background = true;
}
TempFunctionContainer.Name = ParsString.Split("|")[0].Trim().Split(":")[0];
if (ParsString.Split(":").Length > 1)
{
TempFunctionContainer.Param = ParsString.Split(":", 2)[1].Trim();
}
return TempFunctionContainer;
}

}
}