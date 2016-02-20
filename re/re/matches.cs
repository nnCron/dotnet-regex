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
        // Matches str
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.Matches")]
        public static void RegexMatches(
            out wrap matchesOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input
        )
        {
            wrap w = new wrap() { o = re.Matches(input) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.MatchesT")]
        public static void RegexMatchesT(
            out wrap matchesOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input
        )
        {
            wrap w = new wrap() { o = re.Matches(input) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.MatchesA")]
        public static void RegexMatchesA(
            out wrap matchesOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input
        )
        {
            wrap w = new wrap() { o = re.Matches(input) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }





        // **********************************************************
        // Matches str, startat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Matches_startat")]
        public static void RegexMatches_startat(
            out wrap matchesOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int startat
        )
        {
            wrap w = new wrap() { o = re.Matches(input, startat) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Matches_startatT")]
        public static void RegexMatches_startatT(
            out wrap matchesOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int startat
        )
        {
            wrap w = new wrap() { o = re.Matches(input, startat) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Matches_startatA")]
        public static void RegexMatches_startatA(
            out wrap matchesOut,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.I4)] int startat
        )
        {
            wrap w = new wrap() { o = re.Matches(input, startat) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }





        // **********************************************************
        // Matches str, str
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("Matches")]
        public static void reMatches(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("MatchesT")]
        public static void reMatchesT(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("MatchesA")]
        public static void reMatchesA(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }





        // **********************************************************
        // Matches str, str, options
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Matches_opt")]
        public static void reMatches_opt(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern, options) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Matches_optT")]
        public static void reMatches_optT(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern, options) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Matches_optA")]
        public static void reMatches_optA(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern, options) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }





        // **********************************************************
        // Matches str, str, options, time
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Matches_opt_time")]
        public static void reMatches_opt_time(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Matches_opt_timeT")]
        public static void reMatches_opt_timeT(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matchesOut"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Matches_opt_timeA")]
        public static void reMatches_opt_timeA(
            out wrap matchesOut,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            wrap w = new wrap() { o = Regex.Matches(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(w);
            matchesOut = w;
        }





        // **********************************************************
        // Matches for
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wMatch"></param>
        public delegate void matchesForCb(wrap wMatch);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wMatches"></param>
        /// <param name="cb"></param>
        [DllExport("Matches.For")]
        public static void matchesFor(wrap wMatches, matchesForCb cb)
        {
            MatchCollection matches = (MatchCollection)wMatches.o;
            wrap wMatch = new wrap();
            int len = matches.Count;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                wMatch.o = matches[i];
                cb(wMatch);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        [DllExport("Matches.Free")]
        public static void matchesFree(wrap w)
        {
            w.o = null;
            GC.ReRegisterForFinalize(w);
        }
        
    }
}
