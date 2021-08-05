namespace MagicKeys
{
public partial class MagicKeys
{
public static void VUFControlSetText(string Param)
{
string[] FP = Param.Split(",");
ControlSetText(FP[0], FP[1], FP[2], FP[3]);
}

}
}