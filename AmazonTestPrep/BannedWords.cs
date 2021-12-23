// Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.
// The words in paragraph are case-insensitive and the answer should be returned in lowercase.
namespace  leetcode.AmazonTestPrep
{
    public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) 
    {
        var dic = new Dictionary<string, int>();
          // Simple string replace
        var words = paragraph
            .Replace("!", " ")
            .Replace("?"," ")
            .Replace("'"," ")
            .Replace(","," ")
            .Replace("."," ")
            .Replace(";"," ")
            .ToLower()
            .Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
        
        for(int i = 0; i < banned.Length; i++){
            words.RemoveAll(w => w == banned[i]);
        }
        words.ForEach(word => {
            if(!dic.ContainsKey(word))
                dic.Add(word,0);
            dic[word]++;
        });
        var returnValue = dic.Aggregate((w,c) => w.Value > c.Value ? w : c).Key;

        return returnValue;
    }
    }
}

