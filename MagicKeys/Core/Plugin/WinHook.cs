using static MKLib;

namespace MagicKeys
{

public partial class MagicKeys
{

public static (string Title, string Class) WinHook(string WTitle, string WClass)
{
string[] T = WTitle.Split(",");
string[] C = WClass.Split(",");
foreach(string Title in T)
{
foreach(string Class in C)
{
if (WinActive(Title, Class) == true)
{
return (Title, Class);
}
}
}
return (string.Empty, string.Empty);
}

}
}