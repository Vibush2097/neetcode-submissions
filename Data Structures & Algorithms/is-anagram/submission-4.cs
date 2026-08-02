public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) 
            return false;

        int[] count_s = new int[26];
        int[] count_t = new int[26];

        for (int i = 0; i < s.Length; i++) {
            count_s[s[i] - 'a']++;
            count_t[t[i] - 'a']++;
        }

        for (int i = 0; i < 26; i++) {
            if (count_s[i] != count_t[i]) 
                return false;
        }

        return true;
    }
}
