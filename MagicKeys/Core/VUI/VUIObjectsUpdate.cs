namespace MagicKeys
{
public partial class MagicKeys
{
public static void VUIObjectsUpdate(bool StartObject)
{
ActiveObjects.Clear();
foreach(var O in VUIObjects)
{
if (O.Value["Active"] == "true")
{
ActiveObjects.Add(O.Key);
}
}
CountObjects = ActiveObjects.Count-1;
if (StartObject == true)
{
CurrentObject = 0;
}
}

}
}