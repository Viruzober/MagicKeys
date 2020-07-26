using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void VUFVUIObjectSwitcher(String Param)
{
string[] PR = Param.Split("|");
VUIObjectSwitcher(
Convert.ToBoolean(PR[0]),
PR[1],
Convert.ToInt32(PR[2]),
Convert.ToInt32(PR[3])
);
}

}
}