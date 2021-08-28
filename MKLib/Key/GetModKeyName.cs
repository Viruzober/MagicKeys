public static partial class MKLib
{

public static string GetModKeyName(int Mod)
{
string KeyMod = ((MKC.ModKeys)Mod).ToString().Replace(", ", "+");
if (KeyMod == "No")
{
return "";
}
return KeyMod+"+";
}

}