using System.Threading;
using static MKLib;
namespace DeveloperTool
{

public partial class DeveloperTool
{

public static void MouseMover(string To)
{
int[] MP = MKLib.GetMousePosition();
if (To == "Left")
{
if (MP[0]-MouseStep <= Coords.X)
{
SoundPlay("End", false);
MKLib.MouseMove(Coords.X, MP[1], 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0]-MouseStep, MP[1], 0);
}
if (To == "Right")
{
if (MP[0]+MouseStep >= Coords.W)
{
SoundPlay("End", false);
MKLib.MouseMove(Coords.W, MP[1], 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0]+MouseStep, MP[1], 0);
}
if (To == "Up")
{
if (MP[1]-MouseStep <= Coords.Y)
{
SoundPlay("End", false);
MKLib.MouseMove(MP[0], Coords.Y, 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0], MP[1]-MouseStep, 0);
}
if (To == "Down")
{
if (MP[1]+MouseStep >= Coords.H)
{
SoundPlay("End", false);
MKLib.MouseMove(MP[0], Coords.H, 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0], MP[1]+MouseStep, 0);
}
if(AutoOCR == true)
{
WindowsOCR();
}
KeyReg();
}

}
}