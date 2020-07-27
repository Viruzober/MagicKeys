using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
if (API.GetParam() == null)
{
InvokeFromString(API.GetFunc());
return;
}
InvokeFromString(API.GetFunc(), API.GetParam());
}

}
}