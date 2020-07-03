using System;
using System.Reflection;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string GetFullClassName(string Class)
{
Assembly AS = typeof(MagicKeys).Assembly;
Type T = AS.GetType("MagicKeys."+Class);
return T.FullName;
}

}
}