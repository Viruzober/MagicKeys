namespace MagicKeys
{

public partial class MagicKeys
{

public static string VUFControlGetText(string Param)
{
string[] FP = Param.Split(",");
string R = ControlGetText(FP[0], FP[1], FP[2]);
Speak(R);
return R;
}

}
}