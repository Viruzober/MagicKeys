using System;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFMouseMove(String Param)
{
string[] PR = Param.Split(",");
MouseMove(Coords.X+Convert.ToInt32(PR[0]),
Coords.Y+Convert.ToInt32(PR[1]),
Convert.ToInt32(PR[2]));
}

}
}