using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGiesecke.DllExport;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;

namespace re
{
    public static partial class re
    {
        // **********************************************************
        // re.Match input
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.Match")]
        public static void reMatch(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input
        )
        {
            ret = new wrap() { o = re.Match(input) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.MatchT")]
        public static void reMatchT(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input
        )
        {
            ret = new wrap() { o = re.Match(input) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        [DllExport("Regex.MatchA")]
        public static void reMatchA(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input
        )
        {
            ret = new wrap() { o = re.Match(input) };
            GC.SuppressFinalize(ret);
        }



        // **********************************************************
        // re.Match input, startat
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Match_int")]
        public static void reMatch_int(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            int startat
        )
        {
            ret = new wrap() { o = re.Match(input, startat) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Match_intT")]
        public static void reMatch_intT(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            int startat
        )
        {
            ret = new wrap() { o = re.Match(input, startat) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        [DllExport("Regex.Match_intA")]
        public static void reMatch_intA(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            int startat
        )
        {
            ret = new wrap() { o = re.Match(input, startat) };
            GC.SuppressFinalize(ret);
        }



        // **********************************************************
        // re.Match input, startat, len
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        /// <param name="len"></param>
        [DllExport("Regex.Match_int_int")]
        public static void reMatch_int_int(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            int startat,
            int len
        )
        {
            ret = new wrap() { o = re.Match(input, startat, len) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        /// <param name="len"></param>
        [DllExport("Regex.Match_int_intT")]
        public static void reMatch_int_intT(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            int startat,
            int len
        )
        {
            ret = new wrap() { o = re.Match(input, startat, len) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="re"></param>
        /// <param name="input"></param>
        /// <param name="startat"></param>
        /// <param name="len"></param>
        [DllExport("Regex.Match_int_intA")]
        public static void reMatch_int_intA(
            out wrap ret,
            Regex re,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            int startat,
            int len
        )
        {
            ret = new wrap() { o = re.Match(input, startat, len) };
            GC.SuppressFinalize(ret);
        }




        // **********************************************************
        // Regex.Match input, pattern
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("Match")]
        public static void regexMatch(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("MatchT")]
        public static void regexMatchT(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        [DllExport("MatchA", CallingConvention = CallingConvention.StdCall)]
        public static void regexMatchA(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern        
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern) };
            GC.SuppressFinalize(ret);
        }



        // **********************************************************
        // Regex.Match input, pattern, options
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Match_opt")]
        public static void regexMatch_opt(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern, options) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Match_optT")]
        public static void regexMatch_optT(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern, options) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        [DllExport("Match_optA")]
        public static void regexMatch_optA(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options            
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern, options) };
            GC.SuppressFinalize(ret);
        }



        // **********************************************************
        // Regex.Match input, pattern, options, time
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Match_opt_time")]
        public static void regexMatch_opt_time(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPWStr)] string input,
            [MarshalAs(UnmanagedType.LPWStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Match_opt_timeT")]
        public static void regexMatch_opt_timeT(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPTStr)] string input,
            [MarshalAs(UnmanagedType.LPTStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(ret);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ret"></param>
        /// <param name="input"></param>
        /// <param name="pattern"></param>
        /// <param name="options"></param>
        /// <param name="timeSpan"></param>
        [DllExport("Match_opt_timeA")]
        public static void regexMatch_opt_timeA(
            out wrap ret,
            [MarshalAs(UnmanagedType.LPStr)] string input,
            [MarshalAs(UnmanagedType.LPStr)] string pattern,
            [MarshalAs(UnmanagedType.I4)] RegexOptions options,
            [MarshalAs(UnmanagedType.I4)] TimeSpan timeSpan
        )
        {
            ret = new wrap() { o = Regex.Match(input, pattern, options, timeSpan) };
            GC.SuppressFinalize(ret);
        }




        
        // **********************************************************
        // Match methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        [DllExport("Match.Next")]
        public static void matchNext(wrap w)
        {
            w.o = ((Match)w.o).NextMatch();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroups"></param>
        /// <param name="wMatch"></param>
        [DllExport("Match.Groups")]
        public static void matchGroups(out wrap wGroups, wrap wMatch)
        {
            wGroups = new wrap() { o = ((Match)wMatch.o).Groups };
            GC.SuppressFinalize(wGroups);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [DllExport("Match.Success")]
        public static bool matchSuccess(wrap w)
        {
            return ((Match)w.o).Success;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [DllExport("Match.Index")]
        public static Int32 matchIndex(wrap w)
        {
            return ((Match)w.o).Index;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [DllExport("Match.Value")]
        public static string matchValue(wrap w)
        {            
            return ((Match)w.o).Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [DllExport("Match.ValueU")]
        public static IntPtr matchValueU(wrap w)
        {
            return Marshal.StringToCoTaskMemUni(((Match)w.o).Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [DllExport("Match.ValueT")]
        public static IntPtr matchValueT(wrap w)
        {
            return Marshal.StringToCoTaskMemAuto( ((Match)w.o).Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        [DllExport("Match.ValueA")]
        public static IntPtr matchValueA(wrap w)
        {
            return Marshal.StringToCoTaskMemAnsi( ((Match)w.o).Value );
        }






        // **********************************************************
        // Group methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCaptures"></param>
        /// <param name="wGroup"></param>
        [DllExport("Group.Captures")]
        public static void groupCaptures(out wrap wCaptures, wrap wGroup)
        {
            wCaptures = new wrap() { o = ((Group)wGroup.o).Captures };
            GC.SuppressFinalize(wCaptures);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.Index")]
        public static int groupIndex(wrap wGroup)
        {
            return ((Group)wGroup.o).Index;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.Length")]
        public static int groupLength(wrap wGroup)
        {
            return ((Group)wGroup.o).Length;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.Success")]
        public static bool groupSuccess(wrap wGroup)
        {
            return ((Group)wGroup.o).Success;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.Value")]
        public static string groupValue(wrap wGroup)
        {
            return ((Group)wGroup.o).Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.ValueU")]
        public static IntPtr groupValueU(wrap wGroup)
        {
            return Marshal.StringToCoTaskMemUni(((Group)wGroup.o).Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.ValueT")]
        public static IntPtr groupValueT(wrap wGroup)
        {
            return Marshal.StringToCoTaskMemAuto(((Group)wGroup.o).Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wGroup"></param>
        /// <returns></returns>
        [DllExport("Group.ValueA")]
        public static IntPtr groupValueA(wrap wGroup)
        {
            return Marshal.StringToCoTaskMemAnsi(((Group)wGroup.o).Value);
        }






        // **********************************************************
        // Captures methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCapture"></param>
        /// <returns></returns>
        [DllExport("Capture.Index")]
        public static int captureIndex(wrap wCapture)
        {
            return ((Capture)wCapture.o).Index;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCapture"></param>
        /// <returns></returns>
        [DllExport("Capture.Length")]
        public static int captureLength(wrap wCapture)
        {
            return ((Capture)wCapture.o).Length;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCapture"></param>
        /// <returns></returns>
        [DllExport("Capture.Value")]
        public static string captureValue(wrap wCapture)
        {
            return ((Capture)wCapture.o).Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCapture"></param>
        /// <returns></returns>
        [DllExport("Capture.ValueU")]
        public static IntPtr captureValueU(wrap wCapture)
        {
            return Marshal.StringToCoTaskMemUni(((Capture)wCapture.o).Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCapture"></param>
        /// <returns></returns>
        [DllExport("Capture.ValueT")]
        public static IntPtr captureValueT(wrap wCapture)
        {
            return Marshal.StringToCoTaskMemAuto(((Capture)wCapture.o).Value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wCapture"></param>
        /// <returns></returns>
        [DllExport("Capture.ValueA")]
        public static IntPtr captureValueA(wrap wCapture)
        {
            return Marshal.StringToCoTaskMemAnsi(((Capture)wCapture.o).Value);
        }




        // **********************************************************
        // Match.Groups -> positions
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupsOut"></param>
        /// <param name="w"></param>
        [DllExport("Match.Groups.Pos")]
        public static void matchGroupsPos(out IntPtr groupsOut, wrap w)
        {
            GroupCollection groups = ((Match)w.o).Groups;
            Group group;
            int len = groups.Count;
            int i = 0;
            Arr2 groupsArr = new Arr2(len);
            int capturesLen;
            for (i = 0; i < len; i++)
            {
                group = groups[i];
                capturesLen = group.Captures.Count;                
                groupsArr.add( capturesLen );
                foreach (Capture capture in group.Captures)
                {
                    groupsArr.push(capture.Index);
                    groupsArr.push(capture.Length);
                }
                groupsArr.next();
            }
            groupsOut = groupsArr.addr;
        }





        // **********************************************************
        // Match.Groups -> strings (string copy)
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupsOut"></param>
        /// <param name="w"></param>
        [DllExport("Match.Groups.Str")]
        public static void matchGroupsStr(out IntPtr groupsOut, wrap w)
        {
            GroupCollection groups = ((Match)w.o).Groups;
            Group group;
            int len = groups.Count;
            int i = 0;
            Arr2 groupsArr = new Arr2(len);
            int capturesLen;
            for (i = 0; i < len; i++)
            {
                group = groups[i];
                capturesLen = group.Captures.Count;
                groupsArr.add(capturesLen);
                foreach (Capture capture in group.Captures)
                {
                    groupsArr.push(
                        Marshal.StringToCoTaskMemUni(capture.ToString())
                    );
                }
                groupsArr.next();
            }
            groupsOut = groupsArr.addr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupsOut"></param>
        /// <param name="w"></param>
        [DllExport("Match.Groups.StrT")]
        public static void matchGroupsStrT(out IntPtr groupsOut, wrap w)
        {
            GroupCollection groups = ((Match)w.o).Groups;
            Group group;
            int len = groups.Count;
            int i = 0;
            Arr2 groupsArr = new Arr2(len);
            int capturesLen;
            for (i = 0; i < len; i++)
            {
                group = groups[i];
                capturesLen = group.Captures.Count;
                groupsArr.add(capturesLen);
                foreach (Capture capture in group.Captures)
                {
                    groupsArr.push(
                        Marshal.StringToCoTaskMemAuto(capture.ToString())
                    );
                }
                groupsArr.next();
            }
            groupsOut = groupsArr.addr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupsOut"></param>
        /// <param name="w"></param>
        [DllExport("Match.Groups.StrA")]
        public static void matchGroupsStrA(out IntPtr groupsOut, wrap w)
        {
            GroupCollection groups = ((Match)w.o).Groups;
            Group group;
            int len = groups.Count;
            int i = 0;
            Arr2 groupsArr = new Arr2(len);
            int capturesLen;
            for (i = 0; i < len; i++)
            {
                group = groups[i];
                capturesLen = group.Captures.Count;
                groupsArr.add(capturesLen);
                foreach (Capture capture in group.Captures)
                {
                    groupsArr.push(
                        Marshal.StringToCoTaskMemAnsi(capture.ToString())
                    );
                }
                groupsArr.next();
            }
            groupsOut = groupsArr.addr;
        }





        // **********************************************************
        // Match.Groups for
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wrapGroup"></param>
        public delegate void groupForCb(wrap wrapGroup);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        /// <param name="cb"></param>
        [DllExport("Match.Groups.For")]
        public static void matchGroupsFor(wrap w, groupForCb cb)
        {
            GroupCollection groups = ((Match)w.o).Groups;
            wrap wrapGroup = new wrap() { };
            int len = groups.Count;
            int i;
            for (i = 0; i < len; i++)
            {
                wrapGroup.o = groups[i];
                cb(wrapGroup);
            }
        }




        
        // **********************************************************
        // Group.Captures for
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wrapCapture"></param>
        public delegate void captureForCb(wrap wrapCapture);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="wrapGroup"></param>
        /// <param name="cb"></param>
        [DllExport("Group.Captures.For")]
        public static void groupCapturesFor(wrap wrapGroup, captureForCb cb)
        {
            CaptureCollection captures = ((Group)wrapGroup.o).Captures;
            //Group group;
            wrap wrapCapture = new wrap() { };
            int len = captures.Count;
            int i;
            for (i = 0; i < len; i++)
            {
                wrapCapture.o = captures[i];
                cb(wrapCapture);
            }
        }





        // **********************************************************
        // Resources free
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        [DllExport("Value.Free")]
        public static void matchValueFree(IntPtr value)
        {
            Marshal.FreeCoTaskMem(value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        [DllExport("Match.Free")]
        public static void matchFree(wrap w)
        {
            w.o = null;
            GC.ReRegisterForFinalize(w);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        [DllExport("Group.Free")]
        public static void groupFree(wrap w)
        {
            w.o = null; 
            GC.ReRegisterForFinalize(w);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="w"></param>
        [DllExport("Capture.Free")]
        public static void captureFree(wrap w)
        {
            w.o = null; 
            GC.ReRegisterForFinalize(w);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addr"></param>
        [DllExport("Groups.Pos.Free")]
        public static void groupsPosFree(IntPtr addr)
        {
            Arr2.free(addr);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="addr"></param>
        [DllExport("Groups.Str.Free")]
        public static void groupsStrFree(IntPtr addr)
        {
            Arr2.itemsFree(addr);
        }
    }
}
