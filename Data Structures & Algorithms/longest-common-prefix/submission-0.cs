public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int minLength = 201;

        foreach (string s in strs) {
            minLength = Math.Min(minLength, s.Length);
        }
        
        string prefix = "";

        for (int i = 1; i <= minLength; i++) {
            string curPrefix = strs[0][..i];
            for (int j = 0; j < strs.Length; j++) {
                string curString = strs[j][..i];

                if (curString != curPrefix) {
                    return prefix;
                }
            }
            prefix = curPrefix;
        }

        return prefix;
    }
}