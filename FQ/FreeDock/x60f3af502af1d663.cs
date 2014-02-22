﻿using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace FQ.FreeDock
{
    // j
    class x60f3af502af1d663
    {
        public static bool OriginalTheme
        {
            get
            {
                return Path.GetFileName(x60f3af502af1d663.ThemeFilename).ToLower() == "luna.msstyles";
            }
        }

        public static string ThemeFilename
        {
            get
            {
                StringBuilder pszThemeFileName = new StringBuilder(512);
                x60f3af502af1d663.GetCurrentThemeName(pszThemeFileName, pszThemeFileName.Capacity, null, 0, null, 0);
                return pszThemeFileName.ToString();
//                return "noluna";
            }
        }

        public static string ColorScheme
        {
            get
            {
                StringBuilder pszColorBuff = new StringBuilder(512);
                x60f3af502af1d663.GetCurrentThemeName(null, 0, pszColorBuff, pszColorBuff.Capacity, (StringBuilder)null, 0);
                return ((object)pszColorBuff).ToString();
//                return "noluna";
            }
        }

        private x60f3af502af1d663()
        {
        }

        [DllImport("uxtheme.dll", CharSet = CharSet.Auto)]
        private static extern int  GetCurrentThemeName(StringBuilder pszThemeFileName, int dwMaxNameChars, StringBuilder pszColorBuff, int dwMaxColorChars, StringBuilder pszSizeBuff, int cchMaxSizeChars);
    }
}
