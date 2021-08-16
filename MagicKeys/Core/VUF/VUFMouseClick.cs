using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUFMouseClick(String Param)
{
string[] PR = Param.Split(",");
MouseClick(PR[0],
Coords.X+Convert.ToInt32(PR[1]),
Coords.Y+Convert.ToInt32(PR[2]),
Convert.ToInt32(PR[3]),
Convert.ToInt32(PR[4]),
Convert.ToInt32(PR[5]),
Convert.ToInt32(PR[6])
);
}

}
}