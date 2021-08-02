using System;
namespace MagicKeys
{
public partial class MagicKeys
{
public static IntPtr GetMIHandle()
{
IntPtr HMenu = WinExistsHandle("", "#32768");
IntPtr MIHandle = SendMessage(HMenu, 0x01E1, 0, IntPtr.Zero);
return MIHandle;
}
}
}