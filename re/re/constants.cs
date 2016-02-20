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
    /// <summary>
    /// Provide list of constants
    /// </summary>
    public static partial class re
    {
        /// <summary>
        /// Cell size
        /// </summary>
        const int CELL = 4;
        /// <summary>
        /// Specifies that the regular expression is compiled to an assembly. This yields faster execution but increases startup time. This value should not be assigned to the Options property when calling the CompileToAssembly method.
        /// </summary>
        /// <returns>Compiled</returns>
        [DllExport("Options.Compiled")]
        public static RegexOptions optCompiled(){ return RegexOptions.Compiled; }
        /// <summary>
        /// Specifies that cultural differences in language is ignored.
        /// </summary>
        /// <returns>CultureInvariant</returns>
        [DllExport("Options.CultureInvariant")]
        public static RegexOptions optCultureInvariant() { return RegexOptions.CultureInvariant; }
        /// <summary>
        /// Enables ECMAScript-compliant behavior for the expression. This value can be used only in conjunction with the IgnoreCase, Multiline, and Compiled values. The use of this value with any other values results in an exception.
        /// </summary>
        /// <returns>ECMAScript</returns>
        [DllExport("Options.ECMAScript")]
        public static RegexOptions opECMAScriptt() { return RegexOptions.ECMAScript; }
        /// <summary>
        /// Specifies that the only valid captures are explicitly named or numbered groups of the form (?&lt;name&gt;…). This allows unnamed parentheses to act as noncapturing groups without the syntactic clumsiness of the expression (?:…).
        /// </summary>
        /// <returns>ExplicitCapture</returns>
        [DllExport("Options.ExplicitCapture")]
        public static RegexOptions optExplicitCapture() { return RegexOptions.ExplicitCapture; }
        /// <summary>
        /// Specifies case-insensitive matching. 
        /// </summary>
        /// <returns>IgnoreCase</returns>
        [DllExport("Options.IgnoreCase")]
        public static RegexOptions optIgnoreCase() { return RegexOptions.IgnoreCase; }
        /// <summary>
        /// Eliminates unescaped white space from the pattern and enables comments marked with #. However, this value does not affect or eliminate white space in, numeric, or tokens that mark the beginning of individual. 
        /// </summary>
        /// <returns>IgnorePatternWhitespace</returns>
        [DllExport("Options.IgnorePatternWhitespace")]
        public static RegexOptions optIgnorePatternWhitespace() { return RegexOptions.IgnorePatternWhitespace; }
        /// <summary>
        /// Multiline mode. Changes the meaning of ^ and $ so they match at the beginning and end, respectively, of any line, and not just the beginning and end of the entire string.
        /// </summary>
        /// <returns>Multiline</returns>
        [DllExport("Options.Multiline")]
        public static RegexOptions optMultiline() { return RegexOptions.Multiline; }
        /// <summary>
        /// Specifies that no options are set.
        /// </summary>
        /// <returns>None</returns>
        [DllExport("Options.None")]
        public static RegexOptions optNone() { return RegexOptions.None; }
        /// <summary>
        /// Specifies that the search will be from right to left instead of from left to right.
        /// </summary>
        /// <returns>RightToLeft</returns>
        [DllExport("Options.RightToLeft")]
        public static RegexOptions optRightToLeft() { return RegexOptions.RightToLeft; }
        /// <summary>
        /// Specifies single-line mode. Changes the meaning of the dot (.) so it matches every character (instead of every character except \n).
        /// </summary>
        /// <returns>Singleline</returns>
        [DllExport("Options.Singleline")]
        public static RegexOptions optSingleline() { return RegexOptions.Singleline; }
        /// <summary>
        /// Specifies that a pattern-matching operation should not time out.
        /// </summary>
        /// <returns>InfiniteMatchTimeout</returns>
        [DllExport("InfiniteMatchTimeout")]
        public static TimeSpan RegexInfiniteMatchTimeout(){ return Regex.InfiniteMatchTimeout; }
    
    }
}
