namespace MagicKeys
{

public partial class MagicKeys
{

public static void KeyUnReg()
{
int Count = VUIKeys.Count+5;
for(int I = 0; I <= Count; I++)
{
UnregisterHotKey(KeyWndProcHandle.Handle, I);
}
}

}
}