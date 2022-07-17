namespace MagicKeys
{

public partial class MagicKeys
{

public static string GetKeyMod(int Mod)
{
string KeyMod = ((MKC.ModKeys)Mod).ToString().Replace(", ", "+");
if (KeyMod == "No")
{
return "";
}
return KeyMod+"+";
}

}
}