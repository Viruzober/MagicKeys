using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFVUIObjectSwitcher(String Param)
{
string[] PR = Param.Split(",");
bool CheckIndexStr = int.TryParse(PR[2], out _);
if (PR.Length == 3)
{
if (CheckIndexStr == true)
{
VUIObjectSwitcher(Convert.ToBoolean(PR[0]), PR[1], Convert.ToInt32(PR[2]));
}
else
{
VUIObjectSwitcher(Convert.ToBoolean(PR[0]), PR[1], PR[2]);
}
return;
}
if (CheckIndexStr == true)
{
VUIObjectSwitcher(Convert.ToBoolean(PR[0]), PR[1], Convert.ToInt32(PR[2]), Convert.ToInt32(PR[3]));
}
else
{
VUIObjectSwitcher(Convert.ToBoolean(PR[0]), PR[1], PR[2], PR[3]);
}
}

}
}