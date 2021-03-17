using NUnit.Framework;
using System.Collections.Generic;

namespace FloodFillTests
{
    public class SampleInputs
    {
        public static List<string> SampleOne => new List<string>
        {
            "----------------",
            "-++++++++++++++-",
            "-+------------+-",
            "-++++++++++++-+-",
            "-+------------+-",
            "-+-++++++++++++-",
            "-+------------+-",
            "-++++++++++++-+-",
            "-+------------+-",
            "-+-++++++++++++-",
            "-+------------+-",
            "-++++++++++++++-",
            "-+------------+-",
            "-++++++++++++++-",
            "----------------"
        };

        public static List<string> OutputOne => new List<string>
        {
            "----------------",
            "-++++++++++++++-",
            "-+@@@@@@@@@@@@+-",
            "-++++++++++++@+-",
            "-+@@@@@@@@@@@@+-",
            "-+@++++++++++++-",
            "-+@@@@@@@@@@@@+-",
            "-++++++++++++@+-",
            "-+@@@@@@@@@@@@+-",
            "-+@++++++++++++-",
            "-+@@@@@@@@@@@@+-",
            "-++++++++++++++-",
            "-+------------+-",
            "-++++++++++++++-",
            "----------------"            
        };

        public static List<string> SampleTwo => new List<string>
        {
            "aaaaaaaaa",
            "aaadefaaa",
            "abcdafgha",
            "abcdafgha",
            "abcdafgha",
            "abcdafgha",
            "aacdafgaa",
            "aaadafaaa",
            "aaaaaaaaa",
        };

        public static List<string> OutputTwo => new List<string>
        {
            ",,,,,,,,,",
            ",,,def,,,",
            ",bcd,fgh,",
            ",bcd,fgh,",
            ",bcd,fgh,",
            ",bcd,fgh,",
            ",,cd,fg,,",
            ",,,d,f,,,",
            ",,,,,,,,,",
        };

        public static List<string> SampleThree => new List<string>
        {
            @"\/\/\/\.\",
            @"/./..././",
            @"\.\.\.\.\",
            @"/.../.../",
            @"\/\/\/\/\",
            @"/.../.../",
            @"\.\.\.\.\",
            @"/./..././",
            @"\/\/\/\.\",
        };

        public static List<string> OutputThree => new List<string>
        {
            @"\/\/\/\#\",
            @"/#/###/#/",
            @"\#\#\#\#\",
            @"/###/###/",
            @"\/\/\/\/\",
            @"/###/###/",
            @"\#\#\#\#\",
            @"/#/###/#/",
            @"\/\/\/\#\",
        };
    }   
}