## re ##

# T:re.re

 Provide list of constants 



---
##### F:re.re.CELL

 Cell size 



---
##### M:re.re.optCompiled

 Specifies that the regular expression is compiled to an assembly. This yields faster execution but increases startup time. This value should not be assigned to the Options property when calling the CompileToAssembly method. 

Returns: Compiled



---
##### M:re.re.optCultureInvariant

 Specifies that cultural differences in language is ignored. 

Returns: CultureInvariant



---
##### M:re.re.opECMAScriptt

 Enables ECMAScript-compliant behavior for the expression. This value can be used only in conjunction with the IgnoreCase, Multiline, and Compiled values. The use of this value with any other values results in an exception. 

Returns: ECMAScript



---
##### M:re.re.optExplicitCapture

 Specifies that the only valid captures are explicitly named or numbered groups of the form (?<name>.). This allows unnamed parentheses to act as noncapturing groups without the syntactic clumsiness of the expression (?:.). 

Returns: ExplicitCapture



---
##### M:re.re.optIgnoreCase

 Specifies case-insensitive matching. 

Returns: IgnoreCase



---
##### M:re.re.optIgnorePatternWhitespace

 Eliminates unescaped white space from the pattern and enables comments marked with #. However, this value does not affect or eliminate white space in, numeric, or tokens that mark the beginning of individual. 

Returns: IgnorePatternWhitespace



---
##### M:re.re.optMultiline

 Multiline mode. Changes the meaning of ^ and $ so they match at the beginning and end, respectively, of any line, and not just the beginning and end of the entire string. 

Returns: Multiline



---
##### M:re.re.optNone

 Specifies that no options are set. 

Returns: None



---
##### M:re.re.optRightToLeft

 Specifies that the search will be from right to left instead of from left to right. 

Returns: RightToLeft



---
##### M:re.re.optSingleline

 Specifies single-line mode. Changes the meaning of the dot (.) so it matches every character (instead of every character except \n). 

Returns: Singleline



---
##### M:re.re.RegexInfiniteMatchTimeout

 Specifies that a pattern-matching operation should not time out. 

Returns: InfiniteMatchTimeout



---
##### M:re.re.RegexMatches(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.RegexMatchesT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.RegexMatchesA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.RegexMatches_startat(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.RegexMatches_startatT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.RegexMatches_startatA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.reMatches(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.reMatchesT(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.reMatchesA(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.reMatches_opt(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.reMatches_optT(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.reMatches_optA(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.reMatches_opt_time(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.reMatches_opt_timeT(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.reMatches_opt_timeA(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|matchesOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.matchesFor(re.re.wrap,re.re.matchesForCb)



|Name | Description |
|-----|------|
|wMatches: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.matchesFree(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.reFinalize(System.Object)

 Finalize (free) regex object. 

|Name | Description |
|-----|------|
|re: |Object|


---
##### M:re.re.Arr1Free(System.IntPtr)

 Free 1 dim array 

|Name | Description |
|-----|------|
|addr: ||


---
##### M:re.re.Arr2Free(System.IntPtr)

 Free 2 dim array 

|Name | Description |
|-----|------|
|addr: ||


---
##### M:re.re.Arr3Free(System.IntPtr)

 Free 3 dim array 

|Name | Description |
|-----|------|
|addr: ||


---
##### M:re.re.GroupNamesFree(re.re.wrap)

 Free GroupNames wrapper object 

|Name | Description |
|-----|------|
|wGroupNames: ||


---
##### M:re.re.GroupNumbersFree(re.re.wrap)

 Free GroupNames wrapper object 

|Name | Description |
|-----|------|
|wGroupNumbers: ||


---
##### M:re.re.newRegex(System.String)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |UTF16 string|
Returns: Regex object



---
##### M:re.re.newRegexT(System.String)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |Platform dependent string|
Returns: Regex object



---
##### M:re.re.newRegexA(System.String)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |ANSI string|
Returns: Regex object



---
##### M:re.re.regex_opt(System.String,System.Text.RegularExpressions.RegexOptions)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |UTF16 string|
|Name | Description |
|-----|------|
|o: |RegexOptions|
Returns: Regex object



---
##### M:re.re.regexT_opt(System.String,System.Text.RegularExpressions.RegexOptions)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |Platform depended string|
|Name | Description |
|-----|------|
|o: |RegexOptions|
Returns: Regex object



---
##### M:re.re.regex_optA(System.String,System.Text.RegularExpressions.RegexOptions)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |ANSI string|
|Name | Description |
|-----|------|
|o: ||
Returns: Regex object



---
##### M:re.re.regex_opt_time(System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |UTF16 string|
|Name | Description |
|-----|------|
|options: |RegexOptions|
|Name | Description |
|-----|------|
|timeSpan: |TimeSpan|
Returns: Regex object



---
##### M:re.re.regex_opt_timeT(System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |Platform depended string|
|Name | Description |
|-----|------|
|options: |RegexOptions|
|Name | Description |
|-----|------|
|timeSpan: |TimeSpan|
Returns: Regex object



---
##### M:re.re.regex_opt_timeA(System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)

 Create new regex object 

|Name | Description |
|-----|------|
|pattern: |ANSI string|
|Name | Description |
|-----|------|
|options: |RegexOptions|
|Name | Description |
|-----|------|
|timeSpan: |TimeSpan|
Returns: Regex object



---
##### M:re.re.regexMatchTimeout(System.Text.RegularExpressions.Regex)

 Gets the time-out interval of the current instance. 

|Name | Description |
|-----|------|
|re: |Regex object|
Returns: TimeSpan



---
##### M:re.re.regexOptions(System.Text.RegularExpressions.Regex)

 Gets the options that were passed into the Regex constructor. 

|Name | Description |
|-----|------|
|re: |Regex object|
Returns: RegexOptions



---
##### M:re.re.regexRightToLeft(System.Text.RegularExpressions.Regex)

 Gets a value that indicates whether the regular expression searches from right to left. 

|Name | Description |
|-----|------|
|re: |Regex object|
Returns: bool



---
##### M:re.re.regexGetGroupNames(re.re.wrap@,System.Text.RegularExpressions.Regex)

 Returns an array of capturing group names for the regular expression. 

|Name | Description |
|-----|------|
|wGroupNamesOut: |Variable for result|
|Name | Description |
|-----|------|
|re: |Regex object|


---
##### M:re.re.GroupNamesFor(re.re.wrap,re.re.GroupNamesForCb)

 GroupNames loop 

|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|
|Name | Description |
|-----|------|
|cb: |Callback function cb(UTF16 string)|


---
##### M:re.re.GroupNamesForU(re.re.wrap,re.re.GroupNamesForCbPtr)

 GroupNames loop with string allocation 

|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|
|Name | Description |
|-----|------|
|cb: |Callback function cb(UTF16 string)|


---
##### M:re.re.GroupNamesForT(re.re.wrap,re.re.GroupNamesForCbPtr)

 GroupNames loop with string allocation 

|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|
|Name | Description |
|-----|------|
|cb: |Callback function cb(Platform string)|


---
##### M:re.re.GroupNamesForA(re.re.wrap,re.re.GroupNamesForCbPtr)

 GroupNames loop with string allocation 

|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|
|Name | Description |
|-----|------|
|cb: |Callback function cb(ANSI string)|


---
##### M:re.re.GroupNamesToArrU(System.IntPtr@,re.re.wrap)

 Create line array of items 

|Name | Description |
|-----|------|
|arr: |Variable for array|
|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|


---
##### M:re.re.GroupNamesToArrT(System.IntPtr@,re.re.wrap)

 Create line array of items 

|Name | Description |
|-----|------|
|arr: |Variable for array|
|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|


---
##### M:re.re.GroupNamesToArrA(System.IntPtr@,re.re.wrap)

 Create line array of items 

|Name | Description |
|-----|------|
|arr: |Variable for array|
|Name | Description |
|-----|------|
|wGroupNames: |GroupNames object wrapper|


---
##### M:re.re.regexGetGroupNumbers(re.re.wrap@,System.Text.RegularExpressions.Regex)

 Returns an array of capturing group numbers that correspond to group names in an array. 

|Name | Description |
|-----|------|
|wGroupNumbersOut: |Variable for GroupNumbers object|
|Name | Description |
|-----|------|
|re: |Regex object|


---
##### M:re.re.GroupNumbersFor(re.re.wrap,re.re.GroupNumbersForCb)

 GroupNumbers loop 

|Name | Description |
|-----|------|
|wGroupNumbers: |GroupNumbers object wrapper|
|Name | Description |
|-----|------|
|cb: |Callback function cb(int number)|


---
##### M:re.re.GroupNumbersToArr(System.IntPtr@,re.re.wrap)

 Create line array of items 

|Name | Description |
|-----|------|
|arr: |Variable for array|
|Name | Description |
|-----|------|
|wGroupNumbers: |GroupNumbers object wrapper|


---
##### M:re.re.reIsMatch(System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
Returns: 



---
##### M:re.re.reIsMatchT(System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
Returns: 



---
##### M:re.re.reIsMatchA(System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
Returns: 



---
##### M:re.re.reIsMatch_str_int(System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||
Returns: 



---
##### M:re.re.reIsMatch_str_intT(System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||
Returns: 



---
##### M:re.re.reIsMatch_str_intA(System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||
Returns: 



---
##### M:re.re.regexIsMatch(System.String,System.String)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
Returns: 



---
##### M:re.re.regexIsMatchT(System.String,System.String)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
Returns: 



---
##### M:re.re.regexIsMatchA(System.String,System.String)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
Returns: 



---
##### M:re.re.regexIsMatchOpt(System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.regexIsMatchOptT(System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.regexIsMatchOptA(System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.regexIsMatch_opt_time(System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeout: ||
Returns: 



---
##### M:re.re.regexIsMatch_opt_timeT(System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeout: ||
Returns: 



---
##### M:re.re.regexIsMatch_opt_timeA(System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeout: ||
Returns: 



---
##### M:re.re.reMatch(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.reMatchT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.reMatchA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.reMatch_int(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.reMatch_intT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.reMatch_intA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.reMatch_int_int(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||
|Name | Description |
|-----|------|
|len: ||


---
##### M:re.re.reMatch_int_intT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||
|Name | Description |
|-----|------|
|len: ||


---
##### M:re.re.reMatch_int_intA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|startat: ||
|Name | Description |
|-----|------|
|len: ||


---
##### M:re.re.regexMatch(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.regexMatchT(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.regexMatchA(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.regexMatch_opt(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.regexMatch_optT(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.regexMatch_optA(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.regexMatch_opt_time(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.regexMatch_opt_timeT(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.regexMatch_opt_timeA(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|ret: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.matchNext(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.matchGroups(re.re.wrap@,re.re.wrap)



|Name | Description |
|-----|------|
|wGroups: ||
|Name | Description |
|-----|------|
|wMatch: ||


---
##### M:re.re.matchSuccess(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||
Returns: 



---
##### M:re.re.matchIndex(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||
Returns: 



---
##### M:re.re.matchValue(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||
Returns: 



---
##### M:re.re.matchValueU(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||
Returns: 



---
##### M:re.re.matchValueT(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||
Returns: 



---
##### M:re.re.matchValueA(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||
Returns: 



---
##### M:re.re.groupCaptures(re.re.wrap@,re.re.wrap)



|Name | Description |
|-----|------|
|wCaptures: ||
|Name | Description |
|-----|------|
|wGroup: ||


---
##### M:re.re.groupIndex(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.groupLength(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.groupSuccess(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.groupValue(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.groupValueU(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.groupValueT(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.groupValueA(re.re.wrap)



|Name | Description |
|-----|------|
|wGroup: ||
Returns: 



---
##### M:re.re.captureIndex(re.re.wrap)



|Name | Description |
|-----|------|
|wCapture: ||
Returns: 



---
##### M:re.re.captureLength(re.re.wrap)



|Name | Description |
|-----|------|
|wCapture: ||
Returns: 



---
##### M:re.re.captureValue(re.re.wrap)



|Name | Description |
|-----|------|
|wCapture: ||
Returns: 



---
##### M:re.re.captureValueU(re.re.wrap)



|Name | Description |
|-----|------|
|wCapture: ||
Returns: 



---
##### M:re.re.captureValueT(re.re.wrap)



|Name | Description |
|-----|------|
|wCapture: ||
Returns: 



---
##### M:re.re.captureValueA(re.re.wrap)



|Name | Description |
|-----|------|
|wCapture: ||
Returns: 



---
##### M:re.re.matchGroupsPos(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|groupsOut: ||
|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.matchGroupsStr(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|groupsOut: ||
|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.matchGroupsStrT(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|groupsOut: ||
|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.matchGroupsStrA(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|groupsOut: ||
|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.matchGroupsFor(re.re.wrap,re.re.groupForCb)



|Name | Description |
|-----|------|
|w: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.groupCapturesFor(re.re.wrap,re.re.captureForCb)



|Name | Description |
|-----|------|
|wrapGroup: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.matchValueFree(System.IntPtr)



|Name | Description |
|-----|------|
|value: ||


---
##### M:re.re.matchFree(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.groupFree(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.captureFree(re.re.wrap)



|Name | Description |
|-----|------|
|w: ||


---
##### M:re.re.groupsPosFree(System.IntPtr)



|Name | Description |
|-----|------|
|addr: ||


---
##### M:re.re.groupsStrFree(System.IntPtr)



|Name | Description |
|-----|------|
|addr: ||


---
##### M:re.re.RegexReplaceCb(System.Text.RegularExpressions.Regex,System.String,re.re.reReplaceCb)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|cb: ||
Returns: 



---
##### M:re.re.RegexReplaceCbT(System.Text.RegularExpressions.Regex,System.String,re.re.reReplaceCb)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|cb: ||
Returns: 



---
##### M:re.re.RegexReplaceCbA(System.Text.RegularExpressions.Regex,System.String,re.re.reReplaceCb)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|cb: ||
Returns: 



---
##### M:re.re.RegexReplace_cb_count(System.Text.RegularExpressions.Regex,System.String,re.re.reReplaceCb,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|count: ||
Returns: 



---
##### M:re.re.RegexReplace_cb_countT(System.Text.RegularExpressions.Regex,System.String,re.re.reReplaceCb,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|count: ||
Returns: 



---
##### M:re.re.RegexReplace_cb_countA(System.Text.RegularExpressions.Regex,System.String,re.re.reReplaceCb,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|count: ||
Returns: 



---
##### M:re.re.RegexReplace(System.Text.RegularExpressions.Regex,System.String,System.String)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
Returns: 



---
##### M:re.re.RegexReplaceT(System.Text.RegularExpressions.Regex,System.String,System.String)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
Returns: 



---
##### M:re.re.RegexReplaceA(System.Text.RegularExpressions.Regex,System.String,System.String)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
Returns: 



---
##### M:re.re.RegexReplace_count(System.Text.RegularExpressions.Regex,System.String,System.String,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|count: ||
Returns: 



---
##### M:re.re.RegexReplace_countT(System.Text.RegularExpressions.Regex,System.String,System.String,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|count: ||
Returns: 



---
##### M:re.re.RegexReplace_countA(System.Text.RegularExpressions.Regex,System.String,System.String,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|count: ||
Returns: 



---
##### M:re.re.RegexReplace_count_startat(System.Text.RegularExpressions.Regex,System.String,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|count: ||
|Name | Description |
|-----|------|
|startat: ||
Returns: 



---
##### M:re.re.RegexReplace_count_startatT(System.Text.RegularExpressions.Regex,System.String,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|count: ||
|Name | Description |
|-----|------|
|startat: ||
Returns: 



---
##### M:re.re.RegexReplace_count_startatA(System.Text.RegularExpressions.Regex,System.String,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|count: ||
|Name | Description |
|-----|------|
|startat: ||
Returns: 



---
##### M:re.re.reReplace_cb(System.String,System.String,re.re.reReplaceCb)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
Returns: 



---
##### M:re.re.reReplace_cbT(System.String,System.String,re.re.reReplaceCb)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
Returns: 



---
##### M:re.re.reReplace_cbA(System.String,System.String,re.re.reReplaceCb)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
Returns: 



---
##### M:re.re.reReplace_cb_opt(System.String,System.String,re.re.reReplaceCb,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.reReplace_cb_optT(System.String,System.String,re.re.reReplaceCb,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.reReplace_cb_optA(System.String,System.String,re.re.reReplaceCb,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.reReplace_cb_opt_time(System.String,System.String,re.re.reReplaceCb,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||
Returns: 



---
##### M:re.re.reReplace_cb_opt_timeT(System.String,System.String,re.re.reReplaceCb,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||
Returns: 



---
##### M:re.re.reReplace_cb_opt_timeA(System.String,System.String,re.re.reReplaceCb,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|cb: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||
Returns: 



---
##### M:re.re.reReplace(System.String,System.String,System.String)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
Returns: 



---
##### M:re.re.reReplaceT(System.String,System.String,System.String)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
Returns: 



---
##### M:re.re.reReplaceA(System.String,System.String,System.String)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
Returns: 



---
##### M:re.re.reReplace_opt(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.reReplace_optT(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.reReplace_optA(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|options: ||
Returns: 



---
##### M:re.re.reReplace_opt_time(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||
Returns: 



---
##### M:re.re.reReplace_opt_timeT(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||
Returns: 



---
##### M:re.re.reReplace_opt_timeA(System.String,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|replacement: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||
Returns: 



---
##### M:re.re.RegexSplit(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.RegexSplitT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.RegexSplitA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||


---
##### M:re.re.RegexSplit_count(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|count: ||


---
##### M:re.re.RegexSplit_countT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|count: ||


---
##### M:re.re.RegexSplit_countA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|count: ||


---
##### M:re.re.RegexSplit_count_startat(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|count: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.RegexSplit_count_startatT(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|count: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.RegexSplit_count_startatA(re.re.wrap@,System.Text.RegularExpressions.Regex,System.String,System.Int32,System.Int32)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|re: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|count: ||
|Name | Description |
|-----|------|
|startat: ||


---
##### M:re.re.reSplit(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.reSplitT(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.reSplitA(re.re.wrap@,System.String,System.String)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||


---
##### M:re.re.reSplit_opt(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.reSplit_optT(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.reSplit_optA(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||


---
##### M:re.re.reSplit_opt_time(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.reSplit_opt_timeT(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.reSplit_opt_timeA(re.re.wrap@,System.String,System.String,System.Text.RegularExpressions.RegexOptions,System.TimeSpan)



|Name | Description |
|-----|------|
|splitOut: ||
|Name | Description |
|-----|------|
|input: ||
|Name | Description |
|-----|------|
|pattern: ||
|Name | Description |
|-----|------|
|options: ||
|Name | Description |
|-----|------|
|timeSpan: ||


---
##### M:re.re.SplitFor(re.re.wrap,re.re.SplitForCb)



|Name | Description |
|-----|------|
|wSplit: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.SplitForU(re.re.wrap,re.re.SplitForCbPtr)



|Name | Description |
|-----|------|
|wSplit: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.SplitForT(re.re.wrap,re.re.SplitForCbPtr)



|Name | Description |
|-----|------|
|wSplit: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.SplitForA(re.re.wrap,re.re.SplitForCbPtr)



|Name | Description |
|-----|------|
|wSplit: ||
|Name | Description |
|-----|------|
|cb: ||


---
##### M:re.re.SplitToArrU(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|arr: ||
|Name | Description |
|-----|------|
|wSplit: ||


---
##### M:re.re.SplitToArrT(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|arr: ||
|Name | Description |
|-----|------|
|wSplit: ||


---
##### M:re.re.SplitToArrA(System.IntPtr@,re.re.wrap)



|Name | Description |
|-----|------|
|arr: ||
|Name | Description |
|-----|------|
|wSplit: ||


---
##### M:re.re.SplitFree(re.re.wrap)



|Name | Description |
|-----|------|
|wSplit: ||


---
# T:re.re.matchesForCb



|Name | Description |
|-----|------|
|wMatch: ||


---
# T:re.re.GroupNamesForCb

 GroupNames loop delegate 

|Name | Description |
|-----|------|
|result: ||


---
# T:re.re.GroupNamesForCbPtr

 GroupNames loop delegate for allocated string 

|Name | Description |
|-----|------|
|str: ||


---
# T:re.re.GroupNumbersForCb

 GroupNumbers loop delegate 

|Name | Description |
|-----|------|
|number: ||


---
# T:re.re.groupForCb



|Name | Description |
|-----|------|
|wrapGroup: ||


---
# T:re.re.captureForCb



|Name | Description |
|-----|------|
|wrapCapture: ||


---
# T:re.re.reReplaceCb



|Name | Description |
|-----|------|
|wMatch: ||
Returns: 



---
# T:re.re.SplitForCb



|Name | Description |
|-----|------|
|result: ||


---
# T:re.re.SplitForCbPtr



|Name | Description |
|-----|------|
|str: ||


---
# T:re.re.wrap

 Wraper for objects 



---
##### F:re.re.wrap.o

 Object for wrapping 



---
# T:re.re.Arr1

 Line unmanaged Array, [ count, item1, ..., itemN ] 



---
##### F:re.re.Arr1.addr

 Address of array 



---
##### M:re.re.Arr1.len



Returns: 



---
##### M:re.re.Arr1.bytes



Returns: 



---
##### M:re.re.Arr1.#ctor(System.Int32)



|Name | Description |
|-----|------|
|l: ||


---
##### M:re.re.Arr1.push(System.Int32)



|Name | Description |
|-----|------|
|val: ||


---
##### M:re.re.Arr1.push(System.IntPtr)



|Name | Description |
|-----|------|
|val: ||


---
##### M:re.re.Arr1.free





---
##### M:re.re.Arr1.free(System.IntPtr)



|Name | Description |
|-----|------|
|addr: ||


---
# T:re.re.Arr2

 2 dim unmanaged Array, [ count, Arr1, ..., ArrN ] 3 dim unmanaged Array, [ count, Arr1[count, str1, ..., strN], ..., ArrN ] 



---
##### F:re.re.Arr2.addr





---
##### M:re.re.Arr2.len



Returns: 



---
##### M:re.re.Arr2.bytes



Returns: 



---
##### M:re.re.Arr2.#ctor(System.Int32)



|Name | Description |
|-----|------|
|l: ||


---
##### M:re.re.Arr2.add(System.Int32)



|Name | Description |
|-----|------|
|l: ||


---
##### M:re.re.Arr2.next





---
##### M:re.re.Arr2.item



Returns: 



---
##### M:re.re.Arr2.itemLen



Returns: 



---
##### M:re.re.Arr2.push(System.IntPtr)



|Name | Description |
|-----|------|
|val: ||


---
##### M:re.re.Arr2.push(System.Int32)



|Name | Description |
|-----|------|
|val: ||


---
##### M:re.re.Arr2.free





---
##### M:re.re.Arr2.free(System.IntPtr)



|Name | Description |
|-----|------|
|addr: ||


---
##### M:re.re.Arr2.itemsFree(System.IntPtr)



|Name | Description |
|-----|------|
|addr: ||


---



