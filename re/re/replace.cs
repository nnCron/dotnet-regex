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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wMatch"></param>
        /// <returns></returns>
        public delegate IntPtr reReplaceCb(wrap wMatch);

        // **********************************************************
        // Replace input, cb
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_cb")]
        public static IntPtr RegexReplaceCb(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            reReplaceCb cb )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni( 
                re.Replace( 
                    input,
                    (Match m) =>
                    {
                        mWrap.o = m;
                        return Marshal.PtrToStringUni( cb(mWrap) );
                    }
                )
            );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_cbT")]
        public static IntPtr RegexReplaceCbT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            reReplaceCb cb)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni(
                re.Replace(
                    input,
                    (Match m) =>
                    {
                        mWrap.o = m;
                        return Marshal.PtrToStringAuto(cb(mWrap));
                    }
                )
            );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_cbA")]
        public static IntPtr RegexReplaceCbA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            reReplaceCb cb)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni(
                re.Replace(
                    input,
                    (Match m) =>
                    {
                        mWrap.o = m;
                        return Marshal.PtrToStringAnsi(cb(mWrap));
                    }
                )
            );
        }





        // **********************************************************
        // Replace input, cb, count
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="cb"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_cb_count")]
        public static IntPtr RegexReplace_cb_count(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] int count )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni(
                re.Replace(
                    input,
                    (Match m) =>
                    {
                        mWrap.o = m;
                        return Marshal.PtrToStringUni(cb(mWrap));
                    },
                    count
                )
            );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="cb"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_cb_countT")]
        public static IntPtr RegexReplace_cb_countT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] int count)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni(
                re.Replace(
                    input,
                    (Match m) =>
                    {
                        mWrap.o = m;
                        return Marshal.PtrToStringAuto(cb(mWrap));
                    },
                    count
                )
            );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="cb"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_cb_countA")]
        public static IntPtr RegexReplace_cb_countA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] int count)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni(
                re.Replace(
                    input,
                    (Match m) =>
                    {
                        mWrap.o = m;
                        return Marshal.PtrToStringAnsi(cb(mWrap));
                    },
                    count
                )
            );
        }





        // **********************************************************
        // Regex.Replace str, str
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace")]
        public static IntPtr RegexReplace(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement)
        {
            return Marshal.StringToCoTaskMemUni(re.Replace(input, replacement));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [DllExport("Regex.ReplaceT")]
        public static IntPtr RegexReplaceT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement)
        {
            return Marshal.StringToCoTaskMemAuto(re.Replace(input, replacement));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [DllExport("Regex.ReplaceA")]
        public static IntPtr RegexReplaceA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string replacement)
        {
            return Marshal.StringToCoTaskMemAnsi(re.Replace(input, replacement));
        }





        // **********************************************************
        // Regex.Replace str, str, count
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_count")]
        public static IntPtr RegexReplace_count(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] int count )
        {
            return Marshal.StringToCoTaskMemUni(re.Replace(input, replacement, count));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_countT")]
        public static IntPtr RegexReplace_countT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] int count )
        {
            return Marshal.StringToCoTaskMemAuto(re.Replace(input, replacement, count));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_countA")]
        public static IntPtr RegexReplace_countA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] int count)
        {
            return Marshal.StringToCoTaskMemAnsi(re.Replace(input, replacement, count));
        }





        // **********************************************************
        // Regex.Replace str, str, count, startat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <param name="startat"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_count_startat")]
        public static IntPtr RegexReplace_count_startat(
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] int count,
            [MarshalAs(UnmanagedType.I4)] int startat )
        {
            return Marshal.StringToCoTaskMemUni(re.Replace(input, replacement, count, startat));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <param name="startat"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_count_startatT")]
        public static IntPtr RegexReplace_count_startatT(
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] int count,
            [MarshalAs(UnmanagedType.I4)] int startat )
        {
            return Marshal.StringToCoTaskMemAuto(re.Replace(input, replacement, count, startat));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="count"></param>
        /// <param name="startat"></param>
        /// <returns></returns>
        [DllExport("Regex.Replace_count_startatA")]
        public static IntPtr RegexReplace_count_startatA(
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] int count,
            [MarshalAs(UnmanagedType.I4)] int startat )
        {
            return Marshal.StringToCoTaskMemAnsi(re.Replace(input, replacement, count, startat));
        }





        // **********************************************************
        // Replace str, str, cb
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllExport("Replace_cb")]
        public static IntPtr reReplace_cb(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            reReplaceCb cb )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringUni(cb(mWrap));
                }
            ));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllExport("Replace_cbT")]
        public static IntPtr reReplace_cbT(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            reReplaceCb cb)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemAuto( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringAuto(cb(mWrap));
                }
            ));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <returns></returns>
        [DllExport("Replace_cbA")]
        public static IntPtr reReplace_cbA(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            reReplaceCb cb)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemAnsi(Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringAnsi(cb(mWrap));
                }
            ));
        }





        // **********************************************************
        // Replace str, str, cb, options
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("Replace_cb_opt")]
        public static IntPtr reReplace_cb_opt(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringUni(cb(mWrap));
                },
                options
            ));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("Replace_cb_optT")]
        public static IntPtr reReplace_cb_optT(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemAuto( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringAuto(cb(mWrap));
                },
                options
            ));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("Replace_cb_optA")]
        public static IntPtr reReplace_cb_optA(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options)
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemAnsi( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringAnsi(cb(mWrap));
                },
                options
            ));
        }





        // **********************************************************
        // Replace str, str, cb, options, time
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        [DllExport("Replace_cb_opt_time")]
        public static IntPtr reReplace_cb_opt_time(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemUni( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringUni(cb(mWrap));
                },
                options,
                timeSpan
            ));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        [DllExport("Replace_cb_opt_timeT")]
        public static IntPtr reReplace_cb_opt_timeT(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemAuto( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringAuto(cb(mWrap));
                },
                options,
                timeSpan
            ));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="replacement"></param>
        /// <param name="cb"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        [DllExport("Replace_cb_opt_timeA")]
        public static IntPtr reReplace_cb_opt_timeA(
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string replacement,
            reReplaceCb cb,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan )
        {
            wrap mWrap = new wrap();
            return Marshal.StringToCoTaskMemAnsi( Regex.Replace(
                input,
                replacement,
                (Match m) =>
                {
                    mWrap.o = m;
                    return Marshal.PtrToStringAnsi(cb(mWrap));
                },
                options,
                timeSpan
            ));
        }






        // **********************************************************
        // Replace str, str, str
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [DllExport("Replace")]
        public static IntPtr reReplace(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement)
        {
            return Marshal.StringToCoTaskMemUni( Regex.Replace( input, pattern, replacement ) );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [DllExport("ReplaceT")]
        public static IntPtr reReplaceT(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement)
        {
            return Marshal.StringToCoTaskMemAuto(Regex.Replace(input, pattern, replacement));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        [DllExport("ReplaceA")]
        public static IntPtr reReplaceA(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement)
        {
            return Marshal.StringToCoTaskMemAnsi(Regex.Replace(input, pattern, replacement));
        }





        // **********************************************************
        // Replace str, str, str, options
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("Replace_opt")]
        public static IntPtr reReplace_opt(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options )
        {
            return Marshal.StringToCoTaskMemUni(Regex.Replace(input, pattern, replacement, options));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("Replace_optT")]
        public static IntPtr reReplace_optT(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options )
        {
            return Marshal.StringToCoTaskMemAuto(Regex.Replace(input, pattern, replacement, options));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        [DllExport("Replace_optA")]
        public static IntPtr reReplace_optA(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options )
        {
            return Marshal.StringToCoTaskMemAnsi(Regex.Replace(input, pattern, replacement, options));
        }





        // **********************************************************
        // Replace str, str, str, options, time
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        [DllExport("Replace_opt_time")]
        public static IntPtr reReplace_opt_time(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan)
        {
            return Marshal.StringToCoTaskMemUni(Regex.Replace(input, pattern, replacement, options, timeSpan));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        [DllExport("Replace_opt_timeT")]
        public static IntPtr reReplace_opt_timeT(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan)
        {
            return Marshal.StringToCoTaskMemAuto(Regex.Replace(input, pattern, replacement, options, timeSpan));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="replacement"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        [DllExport("Replace_opt_timeA")]
        public static IntPtr reReplace_opt_timeA(
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.LPWStr)] string replacement,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan)
        {
            return Marshal.StringToCoTaskMemAnsi(Regex.Replace(input, pattern, replacement, options, timeSpan));
        }

    }
}
