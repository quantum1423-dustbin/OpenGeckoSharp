namespace Skybound.Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("8ADFB831-1053-4A19-884D-BCDAD7277B4B"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface nsIDocShell : nsISupports
    {
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int loadURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo loadInfo, uint aLoadFlags, bool firstParty);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int loadStream([MarshalAs(UnmanagedType.Interface)] nsIInputStream aStream, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, nsACString aContentType, nsACString aContentCharset, [MarshalAs(UnmanagedType.Interface)] nsIDocShellLoadInfo aLoadInfo);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int internalLoad([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer, [MarshalAs(UnmanagedType.Interface)] IntPtr aOwner, uint aFlags, [MarshalAs(UnmanagedType.LPWStr)] string aWindowTarget, [MarshalAs(UnmanagedType.LPStr)] string aTypeHint, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostDataStream, [MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeadersStream, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry, bool firstParty, [MarshalAs(UnmanagedType.Interface)] out nsIDocShell aDocShell, [MarshalAs(UnmanagedType.Interface)] out nsIRequest aRequest);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int createLoadInfo([MarshalAs(UnmanagedType.Interface)] out nsIDocShellLoadInfo loadInfo);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int prepareForNewContentModel();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setCurrentURI([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int firePageHideNotification(bool isUnload);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getPresContext([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getPresShell(out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getEldestPresShell(out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getContentViewer([MarshalAs(UnmanagedType.Interface)] out nsIContentViewer ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getChromeEventHandler([MarshalAs(UnmanagedType.Interface)] out nsIDOMEventTarget ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setChromeEventHandler([MarshalAs(UnmanagedType.Interface)] nsIDOMEventTarget value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getDocumentCharsetInfo([MarshalAs(UnmanagedType.Interface)] out nsIDocumentCharsetInfo ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setDocumentCharsetInfo([MarshalAs(UnmanagedType.Interface)] nsIDocumentCharsetInfo value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAllowPlugins(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAllowPlugins(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAllowJavascript(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAllowJavascript(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAllowMetaRedirects(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAllowMetaRedirects(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAllowSubframes(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAllowSubframes(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAllowImages(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAllowImages(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getDocShellEnumerator(int aItemType, int aDirection, [MarshalAs(UnmanagedType.Interface)] out nsISimpleEnumerator ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAppType(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAppType(uint value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getAllowAuth(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setAllowAuth(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getZoom(out float ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setZoom(float value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getMarginWidth(out int ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setMarginWidth(int value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getMarginHeight(out int ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setMarginHeight(int value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getHasFocus(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setHasFocus(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getCanvasHasFocus(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setCanvasHasFocus(bool value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int tabToTreeOwner(bool forward, out bool tookFocus);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getBusyFlags(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getLoadType(out uint ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setLoadType(uint value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int isBeingDestroyed(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getIsExecutingOnLoadHandler(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getLayoutHistoryState([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setLayoutHistoryState([MarshalAs(UnmanagedType.Interface)] IntPtr value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getShouldSaveLayoutState(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getSecurityUI([MarshalAs(UnmanagedType.Interface)] out nsISecureBrowserUI ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setSecurityUI([MarshalAs(UnmanagedType.Interface)] nsISecureBrowserUI value);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int suspendRefreshURIs();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int resumeRefreshURIs();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int beginRestore([MarshalAs(UnmanagedType.Interface)] nsIContentViewer viewer, bool top);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int finishRestore();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getPreviousTransIndex(out int ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getLoadedTransIndex(out int ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int historyPurged(int numEntries);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getSessionStorageForURI([MarshalAs(UnmanagedType.Interface)] nsIURI uri, [MarshalAs(UnmanagedType.Interface)] out nsIDOMStorage ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int addSessionStorage(HandleRef aDomain, [MarshalAs(UnmanagedType.Interface)] nsIDOMStorage storage);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getCurrentDocumentChannel([MarshalAs(UnmanagedType.Interface)] out IntPtr ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setChildOffset(uint offset);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getIsInUnload(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getChannelIsUnsafe(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int DetachEditorFromWindow();
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int getIsOffScreenBrowser(out bool ret);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int setIsOffScreenBrowser(bool value);
    }
}

