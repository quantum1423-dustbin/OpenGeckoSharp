namespace Skybound.Gecko
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, Guid("841387C8-72E6-484b-9296-BF6EEA80D58A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface nsIPrintSettingsService
    {
        void getGlobalPrintSettings(out nsIPrintSettings _settings);
        void getNewPrintSettings(out nsIPrintSettings _settings);
        nsIPrintSettings newPrintSettings();
        void getDefaultPrinterName([MarshalAs(UnmanagedType.LPWStr)] out string _defName);
        string setDefaultPrinterName([MarshalAs(UnmanagedType.LPWStr)] string _setval);
        void initPrintSettingsFromPrinter([MarshalAs(UnmanagedType.LPWStr)] string aPrinterName, nsIPrintSettings aPrintSettings);
        void initPrintSettingsFromPrefs(nsIPrintSettings aPrintSettings, bool aUsePrinterNamePrefix, uint aFlags);
        void savePrintSettingsToPrefs(nsIPrintSettings aPrintSettings, bool aUserPrinterNamePrefix, uint aFlags);
    }
}

