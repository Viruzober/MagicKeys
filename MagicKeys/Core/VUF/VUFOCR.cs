using System;
using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFOCR(String Param)
{
string[] PR = Param.Split(",");
string R = ImgToText(
Convert.ToInt32(PR[0]),
Convert.ToInt32(PR[1]),
Coords.X+Convert.ToInt32(PR[2]),
Coords.Y+Convert.ToInt32(PR[3]),
Convert.ToInt32(PR[4]),
PR.Length == 6?PR[5]:"en"
);
Speak(R);
return R;
}

}
}