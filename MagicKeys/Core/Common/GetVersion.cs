namespace MagicKeys
{
public partial class MagicKeys
{
public static string GetVersion()
{
if (GetUpdateChannel() == "Release")
{
return ThisAssembly.Git.BaseTag;
}
return ThisAssembly.Git.Commit;
}

}
}