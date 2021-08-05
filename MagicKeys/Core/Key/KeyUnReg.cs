namespace MagicKeys
{
public partial class MagicKeys
{
public static void KeyUnReg()
{
KeyNavigatorUnReg();
int Count = VUIKeys.Count;
for(int I = 0; I <= Count; I++)
{
UnregisterHotKey(KeyWndProcHandle.Handle, I);
}
}

}
}