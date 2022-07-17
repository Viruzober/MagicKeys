namespace MagicKeys
{

public partial class MagicKeys
{

public static void VUIObjectNavigator(string Navigate)
{
if (Navigate == "Next")
{
if (CurrentPlugin.CurrentVUIObjectNumber >= VisibleVUIObjects.Count-1)
{
CurrentPlugin.CurrentVUIObjectNumber = 0;
}
else
{
CurrentPlugin.CurrentVUIObjectNumber += 1;
}
}
else if (Navigate == "Back")
{
if (CurrentPlugin.CurrentVUIObjectNumber <= 0)
{
CurrentPlugin.CurrentVUIObjectNumber = VisibleVUIObjects.Count-1;
}
else
{
CurrentPlugin.CurrentVUIObjectNumber -= 1;
}
}
VUIObjectSpeak();
}

}
}