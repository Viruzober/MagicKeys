using System.Runtime.InteropServices;
using System.Threading;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void MouseClickDrag(string Button, int X1, int Y1, int X2, int Y2, int TimeMove, int TimeUp)
{
MouseMove(X1, Y1, TimeMove);
MouseButton(Button, "Down");
MouseMove(X2, Y2, TimeMove);
Sleep(TimeUp);
MouseButton(Button, "Up");
}

}
}