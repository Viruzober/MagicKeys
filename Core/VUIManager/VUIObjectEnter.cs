using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
string Func = VUIObjects[ActiveObjects[Section]]["Func"];
InvokeFromString(Func);
}

}
}