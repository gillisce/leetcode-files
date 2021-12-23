namespace leetcode{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hello World");
        var pv = new leetcode.AmazonTestPrep.PrintVerticalWords();
        var testCase = new List<string>(){
            "HOW ARE YOU",
            "TO BE OR NOT TO BE",
            "CONTEST IS COMING",
        };
        foreach(var test in testCase){
            var res = pv.PrintVertically(test);
        }

        // var boldwords = new leetcode.AmazonTestPrep.BoldWords();
        // var testCases = new Dictionary<string, string[]>();
        // testCases.Add("abcxyz123", new string[]{"abc","123"});
        // var output = boldwords.AddBoldTag("abcxyz123",new string[]{"abc","123"}  );
        // Console.WriteLine(output);
//             var test = new leetcode.AmazonTestPrep.Solution();
//             var testCase = "Bob hit a ball, the hit BALL flew far after it was hit.";
//             var banned = new string[]{"hit"};

//             var testCase2 = "a, a, a, a, b,b,b,c, c";
//             var banned2 = new string[]{"a"};


//    var result = test.MostCommonWord(testCase, banned);
//             Console.WriteLine(result);
            
//             var result2 = test.MostCommonWord(testCase2, banned2);
//             Console.WriteLine(result2);

            // var testCase = new List<string>(){
            //     "abcabcbb",
            //     "pwwkew",
            //     "bbbbb",D
            //     "aabaab!bb",
            //     "",
            //     "      ",
            //     " ",
            //     "?fde/dfde/tttt",
            // };
            // testCase.ForEach(t => {
            //     var count = test.LengthOfLongestSubstring(t);
            //     Console.WriteLine($"{t}, Ouput {count}");
            // });
            // string test1 = "abcabcb";
            // var res = test.LengthOfLongestSubstring(test1);
            // Console.WriteLine(res);
            // string test2 = "pwwkew";
            // var res = test.LengthOfLongestSubstring(test2);
            // Console.WriteLine(res);
            // string test3 = "bbbb";
            // var res = test.LengthOfLongestSubstring(test3);
            // Console.WriteLine(res);
        }
    }
}