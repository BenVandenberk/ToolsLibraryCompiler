using System;

namespace toolLibraryCompiler
{
    public static class ExtensionMethods
    {
        public static string TwoDecimals(this string s) {
            return string.Format("{0:0.00}", s);
        }
    }
}