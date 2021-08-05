namespace MagicKeys
{
public partial class MagicKeys
{
public static void SubPluginUnLoad()
{
CurrentPlugin["PluginName"] = CurrentPlugin["PluginName"].Split(".")[0];
CurrentPlugin["PluginClass"] = CurrentPlugin["PluginClass"].Split(".")[0];
}

}
}