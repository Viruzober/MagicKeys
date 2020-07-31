using System;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUIObjectNavigator(string Navigate)
{
if (Navigate == "Next")
{
if (Section >= Count)
{
Section = 0;
}
else
{
Section += 1;
}
}
else if (Navigate == "Back")
{
if (Section == 0)
{
Section = Count;
}
else
{
Section -= 1;
}
}
VUIObjectSpeak();
}

}
}