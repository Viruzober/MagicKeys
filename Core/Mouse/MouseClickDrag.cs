using System.Runtime.InteropServices;
using System.Threading;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void MouseClickDrag(string Button, int X1, int Y1, int X2, int Y2, int TimeMove, int TimeUp)
{
MouseMove(X1, Y1, TimeMove);
Sleep(100);
MouseButton(Button, "Down");
Sleep(100);
MouseMove(X2, Y2, TimeMove);
Sleep(TimeUp);
MouseButton(Button, "Up");
}

}
}