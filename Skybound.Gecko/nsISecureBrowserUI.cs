namespace Skybound.Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("081e31e0-a144-11d3-8c7c-00609792278c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface nsISecureBrowserUI : nsISupports
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getState(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getTooltipText(HandleRef ret);
    }
}

