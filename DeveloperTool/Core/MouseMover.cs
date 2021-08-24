using System.Threading;

namespace MagicKeys
{

public partial class DeveloperTool
{

public static void MouseMover(string To)
{
OCRR = string.Empty;
Thread.Sleep(20);
KeyUnReg();
int[] MP = MKLib.GetMousePosition();
if (To == "Left")
{
if (MP[0]-MouseStep <= P[1])
{
SoundPlay("End", 0);
MKLib.MouseMove(P[1], MP[1], 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0]-MouseStep, MP[1], 0);
}
if (To == "Right")
{
if (MP[0]+MouseStep >= P[3])
{
SoundPlay("End", 0);
MKLib.MouseMove(P[3], MP[1], 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0]+MouseStep, MP[1], 0);
}
if (To == "Up")
{
if (MP[1]-MouseStep <= P[2])
{
SoundPlay("End", 0);
MKLib.MouseMove(MP[0], P[2], 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0], MP[1]-MouseStep, 0);
}
if (To == "Down")
{
if (MP[1]+MouseStep >= P[4])
{
SoundPlay("End", 0);
MKLib.MouseMove(MP[0], P[4], 0);
KeyReg();
return;
}
MKLib.MouseMove(MP[0], MP[1]+MouseStep, 0);
}
if(AutoOCR == 1)
{
WindowsOCR();
}
KeyReg();
}

}
}