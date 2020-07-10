using System.Threading;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void MouseClick(string Button, int X, int Y, int Count, int TimeMove, int TimeClick, int TimeUp)
{
MouseMove(X, Y, TimeMove);
for (int I = 0; I < Count; I++)
{
Sleep(TimeClick);
MouseButton(Button, "Down");
Sleep(TimeUp);
MouseButton(Button, "Up");
}
}

}
}