public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder combined = new StringBuilder();
        int s1 = 0, s2 = 0, turn = 0;

        while (s1 < word1.Length && s2 < word2.Length) {
            if (turn == 0) {
                combined.Append(word1[s1]);
                s1++;
                turn = 1;
            }
            else {
                combined.Append(word2[s2]);
                s2++;
                turn = 0;
            }
        }

        while (s1 < word1.Length) {
            combined.Append(word1[s1]);
            s1++;
        }

        while (s2 < word2.Length) {
            combined.Append(word2[s2]);
            s2++;
        }

        return combined.ToString();
    }
}