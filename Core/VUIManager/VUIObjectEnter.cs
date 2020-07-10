using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
InvokeFromString("KeyUnReg");
string Func = VUIObjects[ActiveObjects[Section]]["Func"];
if (VUIObjects[ActiveObjects[Section]].ContainsKey("Ptr") == false)
{
InvokeFromString(Func);
InvokeFromString("KeyReg");
return;
}
InvokeFromString(Func, VUIObjects[ActiveObjects[Section]]["Ptr"]);
InvokeFromString("KeyReg");
}

}
}