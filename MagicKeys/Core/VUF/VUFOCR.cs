using System;

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
P[1]+Convert.ToInt32(PR[2]),
P[2]+Convert.ToInt32(PR[3]),
Convert.ToInt32(PR[4])
);
Speak(R);
return R;
}

}
}