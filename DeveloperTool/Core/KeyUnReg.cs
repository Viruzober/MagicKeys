using System;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void KeyUnReg()
{
for(int I = 4; I <= 21; I++)
{
MagicKeys.UnregisterHotKey(DeveloperTool.HM.Handle, I);
}
}

public static void OptionKeyUnReg()
{
for(int I = 0; I <= 2; I++)
{
MagicKeys.UnregisterHotKey(DeveloperTool.HM.Handle, I);
}
}

}
}