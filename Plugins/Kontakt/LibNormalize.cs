using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Kontakt
{

public static void LibNormalize()
{
KeyUnReg();
RegisterHotKey(KeyNavigatorHandle.Handle, 21, MKC.CTRL|MKC.SHIFT|MKC.MOD_NOREPEAT, (int)Keys.F4);
try
{
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", P[1]+15, P[2]+75, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 2, 10, 10);
while (ImgSearch(@"Images\Kontakt\KontaktTopLine.bmp")[0] == 0)
{
LoopException();
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", P[1]+15, P[2]+75, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 2, 10, 10);
}
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", P[1]+640, P[2]+50, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 10, 10, 10);
while (ImgSearch(@"Images\Kontakt\KontaktLeftLine.bmp")[0] == 1)
{
LoopException();
CreateOneBitmap(P[1], P[2], P[1]+P[3], P[2]+P[4]);
MouseClick("Left", P[1]+640, P[2]+50, 1, 0, 0, 10);
DisplayTrafic(P[1], P[2], P[1]+P[3], P[2]+P[4], 10, 10, 10);
}
}
catch(Exception)
{
UnregisterHotKey(KeyNavigatorHandle.Handle, 21);
KeySwitch = 1;
LoopError = false;
return;
}
KeyReg();
UnregisterHotKey(KeyNavigatorHandle.Handle, 21);
return;
}

}
}