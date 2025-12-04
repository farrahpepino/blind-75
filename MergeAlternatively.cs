public class Solution {
    public string MergeAlternately(string word1, string word2) {
        char[] word1Arr = word1.ToCharArray();
        char[] word2Arr = word2.ToCharArray();

        List<char> merged = new List<char>();
        int i =0;
        int j=0;
        while(i<word1.Length && j<word2.Length){
            merged.Add(word1Arr[i]);
            merged.Add(word2Arr[j]);
            i++;
            j++;
        }

        while(i<word1.Length){
            merged.Add(word1Arr[i]);
            i++;
        }

          while(j<word2.Length){
            merged.Add(word2Arr[j]);
            j++;
        }

        return new string(merged.ToArray());
    }
}