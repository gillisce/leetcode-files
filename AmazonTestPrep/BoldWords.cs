namespace  leetcode.AmazonTestPrep{
    public class BoldWords{
        class interval
    {
        public int start;
        public int end;
        public interval(int s, int e)
        {
            this.start = s; this.end = e;
        }
    }

    public string AddBoldTag(string s, string[] words)
    {
        var list = new List<interval>();
        var sb = new System.Text.StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            foreach (string w in words)
            {
                 if(w.Length > s.Length - i) continue;
                if (s.Substring(i).StartsWith(w))
                {
                    var str = new interval(i, i + w.Length - 1);
                    // add
                    if (list.Count > 0 && i <= list[list.Count - 1].end + 1)
                    {
                        list[list.Count - 1].end = Math.Max(list[list.Count - 1].end, str.end);
                        continue;
                    }
                    list.Add(str);
                }
            }
        }

        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {

            if (j < list.Count && i == list[j].start) sb.Append("<b>");
            sb.Append(s[i]);
            if (j < list.Count && i == list[j].end) { sb.Append("</b>"); j++; }
        }

        return sb.ToString();
    }
        // public string AddBoldTag(string s, string[] words) {
            
        //     List<string> boldWords = new List<string>();
        //     var wordLocations = new List<int[]>();
            
        //     for(var i = 0; i < s.Length; i++){
        //         foreach(var word in words){
        //             if(word.Length > s.Length - i) continue;
        //             if(s.Substring(i, word.Length) == word){
        //                 wordLocations.Add(new int[]{i, i + word.Length});
        //             }
        //         }
        //     }
        //    var sbuild = new System.Text.StringBuilder(); 
        //     wordLocations.ForEach( coord => {
                
        //     });


        //     return sbuild.ToString();
        // }
    }


    // var mask = new bool[s.Length];
    //     foreach (var word in dict)
    //         for(int i = 0; i <= s.Length - word.Length; i++)
    //             for(int j = 0; j <= word.Length; j++)
    //             {
    //                 if(j == word.Length)
    //                     for(int k = 0; k < word.Length; k++)
    //                         mask[i + k] = true;
    //                 else if(s[i + j] != word[j])
    //                     break;
    //             }
        
    //     var charList = new List<char>();
    //     for (var i = 0; i < s.Length; i++) 
    //     {
    //         if(mask[i] && (i == 0 || !mask[i-1]))
    //             charList.AddRange("<b>".ToCharArray());
    //         else if(!mask[i] && i> 0 && mask[i- 1])
    //             charList.AddRange("</b>".ToArray());
    //         charList.Add(s[i]);
    //     }
        
    //     if(mask[s.Length -1] == true)
    //         charList.AddRange("</b>".ToArray());
        
    //     return new string(charList.ToArray());
 
}
