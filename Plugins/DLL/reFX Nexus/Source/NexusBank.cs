using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;
using static MKLib;
namespace MagicKeys
{

public partial class Nexus
{

public static void NexusBank(string To)
{
if (To == "Back")
{
int[] NXUP = ImgSearchArea("NexusUp", Coords.X+330, Coords.Y+70, Coords.X+350, Coords.Y+130, 40);
if (NXUP[0] == 1)
{
NexusBankPage("Back");
return;
}
else if (NXUP[0] == 0)
{
int[] NXBP = ImgSearchArea("NexusBP", Coords.X+260, Coords.Y+90, Coords.X+280, Coords.Y+270, 20);
if (NXBP[0] == 1)
{
MouseClick("Left", NXBP[1]+15, NXBP[2]-5, 1, 0, 0, 10);
//MouseClick("Right", NXBP[1]+15, NXBP[2]-5, 1, 0, 0, 10);
MenuItemClick("rename");
Thread.Sleep(100);
string Bank = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", Coords.X+450, Coords.Y+105, 2, 0, 0, 50);
Speak(Bank);
}
}
}
else if (To == "Next")
{
int[] NXDW = ImgSearchArea("NexusDown", Coords.X+300, Coords.Y+220, Coords.X+330, Coords.Y+250, 40);
if (NXDW[0] == 1)
{
NexusBankPage("Next");
return;
}
else if (NXDW[0] == 0)
{
int[] NXBP = ImgSearchArea("NexusBP", Coords.X+260, Coords.Y+90, Coords.X+280, Coords.Y+270, 20);
if (NXBP[0] == 1)
{
int[] NXEND = ImgSearchArea("NexusEnd", NXBP[5], NXBP[6], NXBP[5]+15, NXBP[6]+20, 20);
if (NXEND[0] == 1)
{
SoundPlay("End", 0);
}
else if (NXEND[0] == 0)
{
MouseClick("Left", NXBP[1]+15, NXBP[2]+15, 1, 0, 0, 50);
MenuItemClick("rename");
Thread.Sleep(100);
string Bank = ControlGetText(API.GetWTitle(), API.GetWClass(), "Edit");
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", Coords.X+450, Coords.Y+105, 2, 0, 0, 50);
Speak(Bank);
}
}
}
}
}

public static void NexusSearch()
{
NexusSearchForm F = new NexusSearchForm();
F.ShowDialog();
if (F.DialogResult == DialogResult.OK)
{
MouseClick("Right", Coords.X+330, Coords.Y+230, 1, 0, 0, 10);
MenuItemClick("new 'search'");
Thread.Sleep(100);
ControlSetText(API.GetWTitle(), API.GetWClass(), "Edit", F.GetString());
KeySend("Keys", "Enter", 50, 50);
MouseClick("Left", Coords.X+450, Coords.Y+105, 2, 0, 0, 10);
}
}

}
}