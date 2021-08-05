namespace MagicKeys
{
public partial class MagicKeys
{
public static (string, string) FuncParse(string FuncParam)
{
string[] Temp = FuncParam.Split(",", 2);
if (Temp.Length > 1)
{
return (Temp[0], Temp[1]);
}
return (Temp[0], null);
}

}
}