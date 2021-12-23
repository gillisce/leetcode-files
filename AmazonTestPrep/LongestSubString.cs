public class LongestWord {

    private bool IsDistinct(string str, int firstLetter, int secondLetter){
        bool[] visited = new bool[26];
        for(int k = firstLetter; k <= secondLetter; k++)
        {
            if (visited[str[k] - 'a'] == true)
                return false;
                
            visited[str[k] - 'a'] = true;
        }
        return true;
    }

    private string RemoveWhitespace(string input)
 {
    return new string(input.ToCharArray()
        .Where(c => !Char.IsWhiteSpace(c))
        .ToArray());
 }

    public int LengthOfLongestSubstring(string s) {
        string validStr = RemoveWhitespace(s);
        int length = validStr.Length;
        int longest =0;
        for(int i =0; i < length; i++){
            for(int j = i+1; j < length; j++){
                //Console.WriteLine(s[i]);
                //Console.WriteLine(s[j]);
                //Compare letter and next one
                //if same reset count
                //if different add and move on
                if(IsDistinct(validStr,i,j))
                    longest = Math.Max(longest, j-i+1);
            }
        }
        
        return longest == 0 && s.Length >= 1 ? 1 : longest ;
    }
}