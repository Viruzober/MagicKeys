using System;
using System.Diagnostics;
namespace MagicKeys
{
public partial class MagicKeys
{
public static void Sleep(int MS)
{
var x = Stopwatch.StartNew();
x.Restart();
while (x.ElapsedMilliseconds < MS);
}
}
}