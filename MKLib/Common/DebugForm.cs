public static partial class MKLib
{

public static bool DebugMod = true;

public static void CallDebugForm(string DebugInfo)
{
if (DebugMod == false) return;
DebugForm DF = new DebugForm(DebugInfo);
DF.ShowDialog();
}

}