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
        // Split str
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.Split")]
        public static void RegexSplit(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input
        )
        {
            wrap w = new wrap() { o = re.Split(input) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.SplitT")]
        public static void RegexSplitT(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input
        )
        {
            wrap w = new wrap() { o = re.Split(input) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.SplitA")]
        public static void RegexSplitA(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input
        )
        {
            wrap w = new wrap() { o = re.Split(input) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }





        // **********************************************************
        // Split str, count
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="count"></param>
        [DllExport("Regex.Split_count")]
        public static void RegexSplit_count(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int count
        )
        {
            wrap w = new wrap() { o = re.Split(input, count) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="count"></param>
        [DllExport("Regex.Split_countT")]
        public static void RegexSplit_countT(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int count
        )
        {
            wrap w = new wrap() { o = re.Split(input, count) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="count"></param>
        [DllExport("Regex.Split_countA")]
        public static void RegexSplit_countA(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int count
        )
        {
            wrap w = new wrap() { o = re.Split(input, count) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }





        // **********************************************************
        // Split str, count, startat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="count"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Split_count_startat")]
        public static void RegexSplit_count_startat(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int count,
            [MarshalAs(UnmanagedType.I4)] int startat
        )
        {
            wrap w = new wrap() { o = re.Split(input, count, startat) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="count"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Split_count_startatT")]
        public static void RegexSplit_count_startatT(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int count,
            [MarshalAs(UnmanagedType.I4)] int startat
        )
        {
            wrap w = new wrap() { o = re.Split(input, count, startat) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="count"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Split_count_startatA")]
        public static void RegexSplit_count_startatA(
            out wrap splitOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int count,
            [MarshalAs(UnmanagedType.I4)] int startat
        )
        {
            wrap w = new wrap() { o = re.Split(input, count, startat) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }





        // **********************************************************
        // Split str, str
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("Split")]
        public static void reSplit(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("SplitT")]
        public static void reSplitT(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("SplitA")]
        public static void reSplitA(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }





        // **********************************************************
        // Split str, str, options
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Split_opt")]
        public static void reSplit_opt(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern, options) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Split_optT")]
        public static void reSplit_optT(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern, options) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Split_optA")]
        public static void reSplit_optA(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern, options) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }





        // **********************************************************
        // Split str, str, options, time
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Split_opt_time")]
        public static void reSplit_opt_time(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Split_opt_timeT")]
        public static void reSplit_opt_timeT(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="splitOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Split_opt_timeA")]
        public static void reSplit_opt_timeA(
            out wrap splitOut,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            wrap w = new wrap() { o = Regex.Split(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(w);
            splitOut = w;
        }





        // **********************************************************
        // Split for
        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        public delegate void SplitForCb(string result);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wSplit"></param>
        /// <param name="cb"></param>
        [DllExport("Split.For")]
        public static void SplitFor(wrap wSplit, SplitForCb cb)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb( Split[i] );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        public delegate void SplitForCbPtr(IntPtr str);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wSplit"></param>
        /// <param name="cb"></param>
        [DllExport("Split.ForU")]
        public static void SplitForU(wrap wSplit, SplitForCbPtr cb)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb( Marshal.StringToCoTaskMemUni( Split[i] ) );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wSplit"></param>
        /// <param name="cb"></param>
        [DllExport("Split.ForT")]
        public static void SplitForT(wrap wSplit, SplitForCbPtr cb)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(Marshal.StringToCoTaskMemAuto(Split[i]));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wSplit"></param>
        /// <param name="cb"></param>
        [DllExport("Split.ForA")]
        public static void SplitForA(wrap wSplit, SplitForCbPtr cb)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(Marshal.StringToCoTaskMemAnsi(Split[i]));
            }
        }





        // **********************************************************
        // Split toArr
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="wSplit"></param>
        [DllExport("Split.toArrU")]
        public static void SplitToArrU(out IntPtr arr, wrap wSplit)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(Marshal.StringToCoTaskMemUni(Split[i]));
            }
            arr = result.addr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="wSplit"></param>
        [DllExport("Split.toArrT")]
        public static void SplitToArrT(out IntPtr arr, wrap wSplit)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(Marshal.StringToCoTaskMemAuto(Split[i]));
            }
            arr = result.addr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="wSplit"></param>
        [DllExport("Split.toArrA")]
        public static void SplitToArrA(out IntPtr arr, wrap wSplit)
        {
            String[] Split = (String[])wSplit.o;
            int len = Split.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(Marshal.StringToCoTaskMemUni(Split[i]));
            }
            arr = result.addr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wSplit"></param>
        [DllExport("Split.Free")]
        public static void SplitFree(wrap wSplit)
        {
            wSplit.o = null;
            GC.ReRegisterForFinalize(wSplit);
        }

    }
}
