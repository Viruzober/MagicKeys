using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
KeyUnReg();
if (API.GetParam() == null)
{
InvokeFromString(API.GetFunc());
KeyReg();
return;
}
InvokeFromString(API.GetFunc(), API.GetParam());
KeyReg();
}

}
}