namespace MagicKeys
{

public partial class MagicKeys
{

public static void KeyUnReg()
{
int KeysCount = VUIKeys.Count+GetOptionKeys().Count;
for(int I = 0; I <= KeysCount; I++)
{
UnregisterHotKey(KeyWndProcHandle.Handle, I);
}
}

}
}