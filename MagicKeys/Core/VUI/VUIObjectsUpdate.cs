namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectsUpdate(bool StartObject)
{
VisibleVUIObjects.Clear();
foreach(var O in AllVUIObjects)
{
if (O.Visible == true)
{
VisibleVUIObjects.Add(O);
}
}
if (StartObject == true)
{
CurrentPlugin.CurrentVUIObjectNumber = 0;
}
}

}
}