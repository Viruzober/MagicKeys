using System.Diagnostics;

public static partial class MKLib
{

public static void Sleep(int MS)
{
var x = Stopwatch.StartNew();
x.Restart();
while (x.ElapsedMilliseconds < MS)
{
;
}
}

}