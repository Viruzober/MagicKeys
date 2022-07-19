using System;
using System.Threading;
using static MagicKeys.MagicKeys;
using static MKLib;

namespace MagicKeys
{

public partial class Omnisphere
{

public static void Search()
{
MouseClick("Left", Coords.X+35, Coords.Y+85, 1, 0, 0, 10);
Speak("Search");
}

public static void Category()
{
MouseClick("Left", Coords.X+40, Coords.Y+150, 1, 0, 0, 10);
AudoSelect();
Speak("Category");
}

public static void Type()
{
MouseClick("Left", Coords.X+100, Coords.Y+150, 1, 0, 0, 10);
AudoSelect();
Speak("Type");
}

public static void Genre()
{
MouseClick("Left", Coords.X+160, Coords.Y+150, 1, 0, 0, 10);
AudoSelect();
Speak("Genre");
}

public static void SelectChannel()
{
string Input = InputBox("Select Channel", "Enter channel number from 1 to 8.", 1, 8);
if (Input == null)
{
return;
}
int CH = Convert.ToInt32(Input)*35;
MouseClick("Left", Coords.X+485+CH, Coords.Y+55, 1, 0, 0, 10);
AudoSelect();
}

public static void AudoSelect()
{
Thread.Sleep(200);
if (ImageSearchArea("BP", Coords.X+10, Coords.Y+160, Coords.X+50, Coords.Y+385, 20)[0] == 0)
{
MouseClick("Left", Coords.X+220, Coords.Y+170, 1, 0, 0, 10);
}
Thread.Sleep(200);
if (ImageSearchArea("BP", Coords.X+10, Coords.Y+390, Coords.X+50, Coords.Y+620, 20)[0] == 0)
{
MouseClick("Left", Coords.X+220, Coords.Y+400, 1, 0, 0, 10);
}
}

public static void HostAutomation(int X, int Y)
{
MouseClick("Right", X, Y, 1, 0, 0, 10);
if (MenuItemClick("Enable Host") == true)
{
KeySend("Keys", "LCtrl", 100, 100);
Speak("Enabled host automation");
return;
}
else
{
MenuItemClick("Unlearn Host Automation ID");
KeySend("Keys", "LCtrl", 100, 100);
Speak("Disabled host automation");
}
}

}
}