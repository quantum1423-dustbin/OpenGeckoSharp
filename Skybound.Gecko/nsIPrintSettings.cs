﻿namespace Skybound.Gecko
{
    using System;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("343700dd-078b-42b6-a809-b9c1d7e951d0")]
    internal interface nsIPrintSettings
    {
        void SetPrintOptions(int aType, bool aTurnOnOff);
        bool GetPrintOptions(int aType);
        int GetPrintOptionsBits();
        void GetEffectivePageSize(out double aWidth, double aHeight);
        nsIPrintSettings Clone();
        void Assign(nsIPrintSettings aPS);
        nsIPrintSession GetPrintSession();
        void SetPrintSession(nsIPrintSession aPrintSession);
        int GetStartPageRange();
        void SetStartPageRange(int aStartPageRange);
        int GetEndPageRange();
        void SetEndPageRange(int aEndPageRange);
        double GetEdgeTop();
        void SetEdgeTop(double aEdgeTop);
        double GetEdgeLeft();
        void SetEdgeLeft(double aEdgeLeft);
        double GetEdgeBottom();
        void SetEdgeBottom(double aEdgeBottom);
        double GetEdgeRight();
        void SetEdgeRight(double aEdgeRight);
        double GetMarginTop();
        void SetMarginTop(double aMarginTop);
        double GetMarginLeft();
        void SetMarginLeft(double aMarginLeft);
        double GetMarginBottom();
        void SetMarginBottom(double aMarginBottom);
        double GetMarginRight();
        void SetMarginRight(double aMarginRight);
        double GetUnwriteableMarginTop();
        void SetUnwriteableMarginTop(double aUnwriteableMarginTop);
        double GetUnwriteableMarginLeft();
        void SetUnwriteableMarginLeft(double aUnwriteableMarginLeft);
        double GetUnwriteableMarginBottom();
        void SetUnwriteableMarginBottom(double aUnwriteableMarginBottom);
        double GetUnwriteableMarginRight();
        void SetUnwriteableMarginRight(double aUnwriteableMarginRight);
        double GetScaling();
        void SetScaling(double aScaling);
        bool GetPrintBGColors();
        void SetPrintBGColors(bool aPrintBGColors);
        bool GetPrintBGImages();
        void SetPrintBGImages(bool aPrintBGImages);
        short GetPrintRange();
        void SetPrintRange(short aPrintRange);
        string GetTitle();
        void SetTitle(string aTitle);
        string GetDocURL();
        void SetDocURL(string aDocURL);
        string GetHeaderStrLeft();
        void SetHeaderStrLeft(string aHeaderStrLeft);
        string GetHeaderStrCenter();
        void SetHeaderStrCenter(string aHeaderStrCenter);
        string GetHeaderStrRight();
        void SetHeaderStrRight(string aHeaderStrRight);
        string GetFooterStrLeft();
        void SetFooterStrLeft(string aFooterStrLeft);
        string GetFooterStrCenter();
        void SetFooterStrCenter(string aFooterStrCenter);
        string GetFooterStrRight();
        void SetFooterStrRight(string aFooterStrRight);
        short GetHowToEnableFrameUI();
        void SetHowToEnableFrameUI(short aHowToEnableFrameUI);
        bool GetIsCancelled();
        void SetIsCancelled(bool aIsCancelled);
        short GetPrintFrameTypeUsage();
        void SetPrintFrameTypeUsage(short aPrintFrameTypeUsage);
        short GetPrintFrameType();
        void SetPrintFrameType(short aPrintFrameType);
        bool GetPrintSilent();
        void SetPrintSilent(bool aPrintSilent);
        bool GetShrinkToFit();
        void SetShrinkToFit(bool aShrinkToFit);
        bool GetShowPrintProgress();
        void SetShowPrintProgress(bool aShowPrintProgress);
        string GetPaperName();
        void SetPaperName(string aPaperName);
        short GetPaperSizeType();
        void SetPaperSizeType(short aPaperSizeType);
        short GetPaperData();
        void SetPaperData(short aPaperData);
        double GetPaperWidth();
        void SetPaperWidth(double aPaperWidth);
        double GetPaperHeight();
        void SetPaperHeight(double aPaperHeight);
        short GetPaperSizeUnit();
        void SetPaperSizeUnit(short aPaperSizeUnit);
        string GetPlexName();
        void SetPlexName(string aPlexName);
        string GetColorspace();
        void SetColorspace(string aColorspace);
        string GetResolutionName();
        void SetResolutionName(string aResolutionName);
        bool GetDownloadFonts();
        void SetDownloadFonts(bool aDownloadFonts);
        bool GetPrintReversed();
        void SetPrintReversed(bool aPrintReversed);
        bool GetPrintInColor();
        void SetPrintInColor(bool aPrintInColor);
        int GetOrientation();
        void SetOrientation(int aOrientation);
        string GetPrintCommand();
        void SetPrintCommand(string aPrintCommand);
        int GetNumCopies();
        void SetNumCopies(int aNumCopies);
        string GetPrinterName();
        void SetPrinterName(string aPrinterName);
        bool GetPrintToFile();
        void SetPrintToFile(bool aPrintToFile);
        string GetToFileName();
        void SetToFileName(string aToFileName);
        short GetOutputFormat();
        void SetOutputFormat(short aOutputFormat);
        int GetPrintPageDelay();
        void SetPrintPageDelay(int aPrintPageDelay);
        bool GetIsInitializedFromPrinter();
        void SetIsInitializedFromPrinter(bool aIsInitializedFromPrinter);
        bool GetIsInitializedFromPrefs();
        void SetIsInitializedFromPrefs(bool aIsInitializedFromPrefs);
        void SetMarginInTwips(ref nsMargin aMargin);
        void SetEdgeInTwips(ref nsMargin aEdge);
        void GetMarginInTwips(ref nsMargin aMargin);
        void GetEdgeInTwips(ref nsMargin aEdge);
        void SetupSilentPrinting();
        void SetUnwriteableMarginInTwips(ref nsMargin aEdge);
        void GetUnwriteableMarginInTwips(ref nsMargin aEdge);
    }
}
