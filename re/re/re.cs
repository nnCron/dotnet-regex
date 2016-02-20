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
    // WINAPI: regexInfiniteMatchTimeout re.dll
    public static partial class re
    {
        
        // **********************************************************
        // Finalize
        /// <summary>
        /// Finalize (free) regex object.
        /// </summary>
        /// <param name="re">Object</param>
        [DllExport("Regex.Free")]
        public static void reFinalize(Object re)
        {
            GC.ReRegisterForFinalize(re);
        }
        /// <summary>
        /// Free 1 dim array
        /// </summary>
        /// <param name="addr"></param>
        [DllExport("Arr1.Free")]
        public static void Arr1Free(IntPtr addr)
        {
            Arr1.free(addr);
        }
        /// <summary>
        /// Free 2 dim array
        /// </summary>
        /// <param name="addr"></param>
        [DllExport("Arr2.Free")]
        public static void Arr2Free(IntPtr addr)
        {
            Arr2.free(addr);
        }
        /// <summary>
        /// Free 3 dim array
        /// </summary>
        /// <param name="addr"></param>
        [DllExport("Arr3.Free")]
        public static void Arr3Free(IntPtr addr)
        {
            Arr2.itemsFree(addr);
        }
        /// <summary>
        /// Free GroupNames wrapper object
        /// </summary>
        /// <param name="wGroupNames"></param>
        [DllExport("GroupNames.Free")]
        public static void GroupNamesFree(wrap wGroupNames)
        {
            wGroupNames.o = null;
            GC.ReRegisterForFinalize(wGroupNames);
        }
        /// <summary>
        /// Free GroupNames wrapper object
        /// </summary>
        /// <param name="wGroupNumbers"></param>
        [DllExport("GroupNumbers.Free")]
        public static void GroupNumbersFree(wrap wGroupNumbers)
        {
            wGroupNumbers.o = null;
            GC.ReRegisterForFinalize(wGroupNumbers);
        }

        // **********************************************************
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">UTF16 string</param>
        /// <returns>Regex object</returns>
        [DllExport("Regex")]
        public static Regex newRegex(
            [MarshalAs(UnmanagedType.LPWStr)] string pattern
        ){
            Regex r = new Regex(pattern);
            GC.SuppressFinalize(r);
            return r;
        }

        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">Platform dependent string</param>
        /// <returns>Regex object</returns>
        [DllExport("RegexT")]
        public static Regex newRegexT(
            [MarshalAs(UnmanagedType.LPTStr)] string pattern
        ){
            Regex r = new Regex(pattern);
            GC.SuppressFinalize(r);
            return r;
        }

        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">ANSI string</param>
        /// <returns>Regex object</returns>
        [DllExport("RegexA")]
        public static Regex newRegexA(
            [MarshalAs(UnmanagedType.LPStr)]string pattern
        ){
            Regex r = new Regex(pattern);
            GC.SuppressFinalize(r);
            return r;
        }





        // **********************************************************
        // regex options
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">UTF16 string</param>
        /// <param name="o">RegexOptions</param>
        /// <returns>Regex object</returns>
        [DllExport("Regex_opt")]
        public static Regex regex_opt(
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions o
        )
        {
            Regex r = new Regex(pattern, o);
            GC.SuppressFinalize(r);
            return r;
        }
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">Platform depended string</param>
        /// <param name="o">RegexOptions</param>
        /// <returns>Regex object</returns>
        [DllExport("Regex_optT")]
        public static Regex regexT_opt(
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions o
        )
        {
            Regex r = new Regex(pattern, o);
            GC.SuppressFinalize(r);
            return r;
        }
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">ANSI string</param>
        /// <param name="o"></param>
        /// <returns>Regex object</returns>
        [DllExport("Regex_optA")]
        public static Regex regex_optA(
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions o
        )
        {
            Regex r = new Regex(pattern, o);
            GC.SuppressFinalize(r);
            return r;
        }





        // **********************************************************
        // regex options, time
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">UTF16 string</param>
        /// <param name="options">RegexOptions</param>
        /// <param name="timeSpan">TimeSpan</param>
        /// <returns>Regex object</returns>
        [DllExport("Regex_opt_time")]
        public static Regex regex_opt_time(
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            Regex r = new Regex(pattern, options, timeSpan);
            GC.SuppressFinalize(r);
            return r;
        }
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">Platform depended string</param>
        /// <param name="options">RegexOptions</param>
        /// <param name="timeSpan">TimeSpan</param>
        /// <returns>Regex object</returns>
        [DllExport("Regex_opt_timeT")]
        public static Regex regex_opt_timeT(
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            Regex r = new Regex(pattern, options, timeSpan);
            GC.SuppressFinalize(r);
            return r;
        }
        /// <summary>
        /// Create new regex object
        /// </summary>
        /// <param name="pattern">ANSI string</param>
        /// <param name="options">RegexOptions</param>
        /// <param name="timeSpan">TimeSpan</param>
        /// <returns>Regex object</returns>
        [DllExport("Regex_opt_timeA")]
        public static Regex regex_opt_timeA(
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            Regex r = new Regex(pattern, options, timeSpan);
            GC.SuppressFinalize(r);
            return r;
        }


        /// <summary>
        /// Gets the time-out interval of the current instance.
        /// </summary>
        /// <param name="re">Regex object</param>
        /// <returns>TimeSpan</returns>
        [DllExport("Regex.MatchTimeout")]
        public static TimeSpan regexMatchTimeout(Regex re)
        {
            return re.MatchTimeout;
        }

        /// <summary>
        /// Gets the options that were passed into the Regex constructor.
        /// </summary>
        /// <param name="re">Regex object</param>
        /// <returns>RegexOptions</returns>
        [DllExport("Regex.Options")]
        public static RegexOptions regexOptions(Regex re)
        {
            return re.Options;
        }

        /// <summary>
        /// Gets a value that indicates whether the regular expression searches from right to left.
        /// </summary>
        /// <param name="re">Regex object</param>
        /// <returns>bool</returns>
        [DllExport("Regex.RightToLeft")]
        public static bool regexRightToLeft(Regex re)
        {
            return re.RightToLeft;
        }





        // **********************************************************
        // GroupNames
        /// <summary>
        /// Returns an array of capturing group names for the regular expression.
        /// </summary>
        /// <param name="wGroupNamesOut">Variable for result</param>
        /// <param name="re">Regex object</param>
        [DllExport("Regex.GetGroupNames")]
        public static void regexGetGroupNames(out wrap wGroupNamesOut, Regex re)
        {
            String[] groupNames = re.GetGroupNames();
            wrap wGroupNames = new wrap() { o = groupNames };
            wGroupNamesOut = wGroupNames;
        }


        


        // **********************************************************
        // GroupNames for
        /// <summary>
        /// GroupNames loop delegate
        /// </summary>
        /// <param name="result"></param>
        public delegate void GroupNamesForCb(string result);

        /// <summary>
        /// GroupNames loop
        /// </summary>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        /// <param name="cb">Callback function cb(UTF16 string)</param>
        [DllExport("GroupNames.For")]
        public static void GroupNamesFor(wrap wGroupNames, GroupNamesForCb cb)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(names[i]);
            }
        }
        /// <summary>
        /// GroupNames loop delegate for allocated string
        /// </summary>
        /// <param name="str"></param>
        public delegate void GroupNamesForCbPtr(IntPtr str);
        /// <summary>
        /// GroupNames loop with string allocation
        /// </summary>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        /// <param name="cb">Callback function cb(UTF16 string)</param>
        [DllExport("GroupNames.ForU")]
        public static void GroupNamesForU(wrap wGroupNames, GroupNamesForCbPtr cb)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(Marshal.StringToCoTaskMemUni(names[i]));
            }
        }
        /// <summary>
        /// GroupNames loop with string allocation
        /// </summary>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        /// <param name="cb">Callback function cb(Platform string)</param>
        [DllExport("GroupNames.ForT")]
        public static void GroupNamesForT(wrap wGroupNames, GroupNamesForCbPtr cb)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(Marshal.StringToCoTaskMemAuto(names[i]));
            }
        }
        /// <summary>
        /// GroupNames loop with string allocation
        /// </summary>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        /// <param name="cb">Callback function cb(ANSI string)</param>
        [DllExport("GroupNames.ForA")]
        public static void GroupNamesForA(wrap wGroupNames, GroupNamesForCbPtr cb)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(Marshal.StringToCoTaskMemAnsi(names[i]));
            }
        }





        // **********************************************************
        // GroupNames toArr
        /// <summary>
        /// Create line array of items
        /// </summary>
        /// <param name="arr">Variable for array</param>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        [DllExport("GroupNames.toArrU")]
        public static void GroupNamesToArrU(out IntPtr arr, wrap wGroupNames)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(Marshal.StringToCoTaskMemUni(names[i]));
            }
            arr = result.addr;
        }
        /// <summary>
        /// Create line array of items
        /// </summary>
        /// <param name="arr">Variable for array</param>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        [DllExport("GroupNames.toArrT")]
        public static void GroupNamesToArrT(out IntPtr arr, wrap wGroupNames)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(Marshal.StringToCoTaskMemAuto(names[i]));
            }
            arr = result.addr;
        }
        /// <summary>
        /// Create line array of items
        /// </summary>
        /// <param name="arr">Variable for array</param>
        /// <param name="wGroupNames">GroupNames object wrapper</param>
        [DllExport("GroupNames.toArrA")]
        public static void GroupNamesToArrA(out IntPtr arr, wrap wGroupNames)
        {
            String[] names = (String[])wGroupNames.o;
            int len = names.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(Marshal.StringToCoTaskMemUni(names[i]));
            }
            arr = result.addr;
        }





        // **********************************************************
        // GroupNumbers
        /// <summary>
        /// Returns an array of capturing group numbers that correspond to group names in an array.
        /// </summary>
        /// <param name="wGroupNumbersOut">Variable for GroupNumbers object</param>
        /// <param name="re">Regex object</param>
        [DllExport("Regex.GetGroupNumbers")]
        public static void regexGetGroupNumbers(out wrap wGroupNumbersOut, Regex re)
        {
            int[] numbers = re.GetGroupNumbers();
            wrap w = new wrap() { o = numbers };
            wGroupNumbersOut = w;
        }





        // **********************************************************
        // GroupNumbers for
        /// <summary>
        /// GroupNumbers loop delegate
        /// </summary>
        /// <param name="number"></param>
        public delegate void GroupNumbersForCb(int number);
        /// <summary>
        /// GroupNumbers loop 
        /// </summary>
        /// <param name="wGroupNumbers">GroupNumbers object wrapper</param>
        /// <param name="cb">Callback function cb(int number)</param>
        [DllExport("GroupNumbers.For")]
        public static void GroupNumbersFor(wrap wGroupNumbers, GroupNumbersForCb cb)
        {
            int[] numbers = (int[])wGroupNumbers.o;
            int len = numbers.Length;
            int i = 0;
            for (i = 0; i < len; i++)
            {
                cb(numbers[i]);
            }
        }




        // **********************************************************
        // GroupNumbers toArr
        /// <summary>
        /// Create line array of items
        /// </summary>
        /// <param name="arr">Variable for array</param>
        /// <param name="wGroupNumbers">GroupNumbers object wrapper</param>
        [DllExport("GroupNumbers.toArr")]
        public static void GroupNumbersToArr(out IntPtr arr, wrap wGroupNumbers)
        {
            int[] numbers = (int[])wGroupNumbers.o;
            int len = numbers.Length;
            Arr1 result = new Arr1(len);
            int i = 0;
            for (i = 0; i < len; i++)
            {
                result.push(numbers[i]);
            }
            arr = result.addr;
        }

    }

}
