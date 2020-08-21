using System;
using System.Threading;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class Kontakt
{

public static void LibNormalize()
{
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+15, P[2]+75, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 3, 3, 10);
while (ImgSearch("KontaktTopLine", true)[0] == 0)
{
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+15, P[2]+75, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 3, 3, 10);
}
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+640, P[2]+50, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 3, 3, 10);
while (ImgSearch("KontaktLeftLine", true)[0] == 1)
{
CreateOneBitmap(P[1], P[2], P[3], P[4]);
MouseClick("Left", P[1]+640, P[2]+50, 1, 0, 0, 10);
DisplayTraffic(P[1], P[2], P[3], P[4], 3, 3, 10);
}
}

}
}