using System;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public partial class MagicKeys
{

public static int[] GetPos()
{
int[] ControlCoord;
if (PluginsList[0].ContainsKey("PluginImg") == true)
{
int[] Img = ImgSearch(@PluginsList[0]["PluginImg"]);
if (Img[0] == 1)
{
IntPtr Handle = GetWinPointHandle(Img[5], Img[6]);
int[] Rect = GetWinRect(Handle);
ControlCoord = new int[5] {Img[0], Rect[0], Rect[1], Rect[2], Rect[3]};
return ControlCoord;
}
else
{
return Img;
}
}
else
{
IntPtr Handle = GetForegroundWindow();
int[] Rect = GetWinRect(Handle);
if (Rect[0] == 0 & Rect[1] == 0 & Rect[2] == 0 & Rect[3] == 0)
{
ControlCoord = new int[5] {0, Rect[0], Rect[1], Rect[2], Rect[3]};
return ControlCoord;;
}
IntPtr HandleCTRL = GetWinPointHandle(Rect[0]+100, Rect[1]+100);
int[] RectCTRL = GetWinRect(HandleCTRL);
if (RectCTRL[0] == 0 & RectCTRL[1] == 0 & RectCTRL[2] == 0 & RectCTRL[3] == 0)
{
ControlCoord = new int[5] {0, RectCTRL[0], RectCTRL[1], RectCTRL[2], RectCTRL[3]};
return ControlCoord;;
}
ControlCoord = new int[5] {1, RectCTRL[0], RectCTRL[1], RectCTRL[2], RectCTRL[3]};
return ControlCoord;;
}
}

}
}