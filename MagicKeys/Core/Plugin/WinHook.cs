using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string[] WinHook(string WTitle, string WClass)
{
string[] T = WTitle.Split(",");
string[] C = WClass.Split(",");
foreach(string Title in T)
{
foreach(string Class in C)
{
if (WinActive(Title, Class) == true)
{
return new string[2] {Title, Class};
}
}
}
return new string[2] {null, null};
}

}
}