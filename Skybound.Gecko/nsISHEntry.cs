namespace Skybound.Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("c16fde76-3108-450e-8c8c-ae8286f286ed"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface nsISHEntry : nsIHistoryEntry
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getViewerBounds([MarshalAs(UnmanagedType.Interface)] IntPtr bounds);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setViewerBounds([MarshalAs(UnmanagedType.Interface)] IntPtr bounds);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int childShellAt(int index, [MarshalAs(UnmanagedType.Interface)] out nsIDocShellTreeItem ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int clearChildShells();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int syncPresentationState();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getLoadType(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setLoadType(uint value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getID(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setID(uint value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getPageIdentifier(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setPageIdentifier(uint value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getContentType(HandleRef ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setContentType(HandleRef value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAnyContentViewer([MarshalAs(UnmanagedType.Interface)] out nsISHEntry ownerEntry, [MarshalAs(UnmanagedType.Interface)] out nsIContentViewer ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getOwner([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setOwner([MarshalAs(UnmanagedType.Interface)] IntPtr value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int forgetEditorData([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setEditorData([MarshalAs(UnmanagedType.Interface)] IntPtr aData);
    }
}

