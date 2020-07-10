using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static IntPtr GetParentWindow(IntPtr HWND)
{
IntPtr Handle = GetAncestor(HWND, 2);
return Handle;
}

}
}