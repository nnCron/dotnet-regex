using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace re
{

    // WINAPI: encodingDefaultWindowsCodePage re.dll
    // WINAPI: str re.dll
    public class re
    {

        //[DllExport("add", CallingConvention = CallingConvention.Cdecl)]
        [DllExport("str")]
        public static IntPtr str()
        {
            return Marshal.StringToCoTaskMemUni("\uFEFF    строка    ");
        }


        //Regex r = new Regex("", RegexOptions.Compiled);
        [DllExport("ro")]
        public static RegexOptions ro()
        {
            return RegexOptions.None;
        }

        //[DllExport("encodingDefaultWindowsCodePage")]
        //public static int encodingDefault()
        //{
        //    return Encoding.Default.WindowsCodePage;
        //}

        // regex
        [DllExport("regex")]
        public static Regex newRegex(
            [MarshalAs(UnmanagedType.LPWStr)] string s
        ){
            return new Regex(s);
        }

        [DllExport("regexT")]
        public static Regex newRegexT(
            [MarshalAs(UnmanagedType.LPTStr)] string s
        ){
            return new Regex(s);
        }

        [DllExport("regexA")]
        public static Regex newRegexA(
            [MarshalAs(UnmanagedType.LPStr)]string s
        ){
            return new Regex(s);
        }



        // regex + options
        [DllExport("regex_opt")]
        public static Regex newRegex_opt(
            [MarshalAs(UnmanagedType.LPWStr)] string s, 
            RegexOptions o
        ){
            return new Regex(s, o);
        }

        [DllExport("regexT_opt")]
        public static Regex newRegexT_opt(
            [MarshalAs(UnmanagedType.LPTStr)] string s, 
            RegexOptions o
        ){
            return new Regex(s, o);
        }

        [DllExport("regexA_opt")]
        public static Regex newRegexA_opt(
            [MarshalAs(UnmanagedType.LPStr)] string s,
            RegexOptions o
        ){
            return new Regex(s, o);
        }



        // regex + options + time
        [DllExport("regex_opt_time")]
        public static Regex newRegex_opt_time(
            [MarshalAs(UnmanagedType.LPWStr)] string s, 
            RegexOptions o, 
            TimeSpan t
        ){
            return new Regex(s, o, t);
        }

        [DllExport("regexT_opt_time")]
        public static Regex newRegexT_opt_time(
            [MarshalAs(UnmanagedType.LPTStr)] string s,
            RegexOptions o,
            TimeSpan t
        )
        {
            return new Regex(s, o, t);
        }

        [DllExport("regexA_opt_time")]
        public static Regex newRegexA_opt_time(
            [MarshalAs(UnmanagedType.LPStr)] string s,
            RegexOptions o,
            TimeSpan t
        ){
            return new Regex(s, o, t);
        }
    }
}
