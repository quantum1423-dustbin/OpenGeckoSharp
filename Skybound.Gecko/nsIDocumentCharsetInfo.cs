namespace Skybound.Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("2d40b291-01e1-11d4-9d0e-0050040007b2")]
    internal interface nsIDocumentCharsetInfo : nsISupports
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getForcedCharset([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setForcedCharset([MarshalAs(UnmanagedType.Interface)] IntPtr value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getForcedDetector(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setForcedDetector(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getParentCharset([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setParentCharset([MarshalAs(UnmanagedType.Interface)] IntPtr value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getParentCharsetSource(out int ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setParentCharsetSource(int value);
    }
}

