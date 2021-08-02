using System;
namespace MagicKeys
{
public partial class MagicKeys
{
public static string GetUpdateChannel()
{
if (ThisAssembly.Git.Tag == ThisAssembly.Git.BaseTag)
{
return "Release";
}
else
{
return "Nightly";
}
}
}
}