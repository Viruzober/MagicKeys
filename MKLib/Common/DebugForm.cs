public static partial class MKLib
{

public static void CallDebugForm(string DebugInfo)
{
DebugForm DF = new DebugForm(DebugInfo);
DF.ShowDialog();
}

}