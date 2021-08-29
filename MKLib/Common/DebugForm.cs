public static partial class MKLib
{

public static void DebugForm(string DebugInfo)
{
DebugForm DF = new DebugForm(DebugInfo);
DF.ShowDialog();
}

}