using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectEnter()
{
string Func = VUIObjects[ActiveObjects[Section]]["Func"];
if (VUIObjects[ActiveObjects[Section]].ContainsKey("Ptr") == false)
{
InvokeFromString(Func);
return;
}
InvokeFromString(Func, VUIObjects[ActiveObjects[Section]]["Ptr"]);
}

}
}