namespace MagicKeys
{

public partial class DeveloperTool
{

public static void KeyUnReg()
{
for(int I = 4; I <= 26; I++)
{
MKLib.UnregisterHotKey(DeveloperTool.HM.Handle, I);
}
}

public static void OptionKeyUnReg()
{
for(int I = 0; I <= 3; I++)
{
MKLib.UnregisterHotKey(DeveloperTool.HM.Handle, I);
}
}

}
}