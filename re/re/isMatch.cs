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
    public static partial class re
    {
        // **********************************************************
        // IsMatch input
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [DllExport("Regex.IsMatch")]
        public static bool reIsMatch(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input
        )
        {
            return re.IsMatch(input);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [DllExport("Regex.IsMatchT")]
        public static bool reIsMatchT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input
        )
        {
            return re.IsMatch(input);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        [DllExport("Regex.IsMatchA")]
        public static bool reIsMatchA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input
        )
        {
            return re.IsMatch(input);
        }


        // **********************************************************
        // IsMatch input startat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        /// <returns></returns>
        [DllExport("Regex.IsMatch_str_int")]
        public static bool reIsMatch_str_int(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            int startat
        )
        {
            return re.IsMatch(input, startat);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        /// <returns></returns>
        [DllExport("Regex.IsMatch_str_intT")]
        public static bool reIsMatch_str_intT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            int startat
        )
        {
            return re.IsMatch(input, startat);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        /// <returns></returns>
        [DllExport("Regex.IsMatch_str_intA")]
        public static bool reIsMatch_str_intA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            int startat
        )
        {
            return re.IsMatch(input, startat);
        }




        // **********************************************************
        // IsMatch input, pattern
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        [DllExport("IsMatch")]
        public static bool regexIsMatch(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern
            //[MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            return Regex.IsMatch(input, pattern);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        [DllExport("IsMatchT")]
        public static bool regexIsMatchT(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern
            //[MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            return Regex.IsMatch(input, pattern);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        [DllExport("IsMatchA")]
        public static bool regexIsMatchA(
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern
            //,
            //[MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            return Regex.IsMatch(input, pattern);
        }





        // **********************************************************
        // IsMatch input, pattern, options
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("IsMatch_opt")]
        public static bool regexIsMatchOpt(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            return Regex.IsMatch(input, pattern, options);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("IsMatch_optT")]
        public static bool regexIsMatchOptT(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            return Regex.IsMatch(input, pattern, options);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("IsMatch_optA")]
        public static bool regexIsMatchOptA(
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            return Regex.IsMatch(input, pattern, options);
        }




        // **********************************************************
        // IsMatch input, pattern, options, time
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        [DllExport("IsMatch_opt_time")]
        public static bool regexIsMatch_opt_time(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeout
        )
        {
            return Regex.IsMatch(input, pattern, options, timeout);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        [DllExport("IsMatch_opt_timeT")]
        public static bool regexIsMatch_opt_timeT(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeout
        )
        {
            return Regex.IsMatch(input, pattern, options, timeout);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        [DllExport("IsMatch_timeA")]
        public static bool regexIsMatch_opt_timeA(
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeout
        )
        {
            return Regex.IsMatch(input, pattern, options, timeout);
        }
    }
}
