using System;

namespace MagicKeys
{
public partial class DeveloperTool
{

public static void KeyUnReg()
{
for(int I = 4; I <= 10; I++)
{
MagicKeys.UnregisterHotKey(DeveloperTool.HM.Handle, I);
}
}

}
}