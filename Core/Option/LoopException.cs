using System;
using System.Windows.Forms;

namespace MagicKeys
{
public partial class MagicKeys
{

public static void LoopException()
{
Application.DoEvents();
if (LoopError == true)
{
throw new Exception();
}
}

}
}