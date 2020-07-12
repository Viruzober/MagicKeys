using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
InvokeFromString("KeyUnReg");
if (API.GetParam() == null)
{
InvokeFromString(API.GetFunc());
InvokeFromString("KeyReg");
return;
}
InvokeFromString(API.GetFunc(), API.GetParam());
InvokeFromString("KeyReg");
}

}
}