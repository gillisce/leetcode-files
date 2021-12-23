namespace leetcode.AmazonTestPrep
{
    public class PrintVerticalWords{
         public IList<string> PrintVertically(string s) {
        
        var words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        int maxLength = words.Max(str=> str == null ? 0 : str.Length); 
        var newWords = new string[maxLength];
        foreach(var word in words){
         for(int i = 0; i < maxLength; i++){
             if( i < word.Length)
                newWords[i] += word[i];
            else
                newWords[i] += " ";
         }

        }
        
        return (from word in newWords select word.TrimEnd()).ToList();
    }
    }
}