using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace MagicKeys
{
public static partial class Nexus
{

public static NexusKey NexusKeyHandle = new NexusKey();

public static void KeyReg()
{
KeyNavigatorReg("Space");
RegisterHotKey(NexusKeyHandle.Handle, 4, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Home);
RegisterHotKey(NexusKeyHandle.Handle, 5, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.End);
RegisterHotKey(NexusKeyHandle.Handle, 6, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Prior);
RegisterHotKey(NexusKeyHandle.Handle, 7, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.Next);
RegisterHotKey(NexusKeyHandle.Handle, 8, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Home);
RegisterHotKey(NexusKeyHandle.Handle, 9, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.End);
RegisterHotKey(NexusKeyHandle.Handle, 10, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Prior);
RegisterHotKey(NexusKeyHandle.Handle, 11, MKC.CTRL|MKC.MOD_NOREPEAT, (int)Keys.Next);
RegisterHotKey(NexusKeyHandle.Handle, 12, MKC.NOMOD|MKC.MOD_NOREPEAT, (int)Keys.S);
}

public static void KeyUnReg()
{
KeyNavigatorUnReg();
UnregisterHotKey(NexusKeyHandle.Handle, 4);
UnregisterHotKey(NexusKeyHandle.Handle, 5);
UnregisterHotKey(NexusKeyHandle.Handle, 6);
UnregisterHotKey(NexusKeyHandle.Handle, 7);
UnregisterHotKey(NexusKeyHandle.Handle, 8);
UnregisterHotKey(NexusKeyHandle.Handle, 9);
UnregisterHotKey(NexusKeyHandle.Handle, 10);
UnregisterHotKey(NexusKeyHandle.Handle, 11);
UnregisterHotKey(NexusKeyHandle.Handle, 12);
}

}
}