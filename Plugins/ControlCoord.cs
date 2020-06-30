using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class MagicKeys
{
public static int[] GetPos()
{
IntPtr Handle = GetForegroundWindow();
int[] Rect = GetWinRect(Handle);
IntPtr HandleCTRL = GetWinPointHandle(Rect[0]+100, Rect[1]+100);
int[] RectCTRL = GetWinRect(HandleCTRL);
int[] ControlCoord;
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2], RectCTRL[3]};
return ControlCoord;;
}

}
}