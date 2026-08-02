public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();
        
        foreach(string s in strs) {
            var charCounts = getCharCount(s);
            string key = GetKey(charCounts);

            if (!groups.ContainsKey(key)) {
                groups.Add(key, new List<string> {s});
            }
            else {
                groups[key].Add(s);
            }
        }

        return new List<List<string>>(groups.Values);
    }

    private int[] getCharCount(string s) {
        int[] charCounts = new int[26];
        int idx;

        for (int i = 0; i < s.Length; i++) {
            idx = s[i] - 'a';
            charCounts[idx]++;
        }

        return charCounts;
    }

    private string GetKey(int[] charCounts) {
        string key = "";

        for (int i = 0; i < charCounts.Length; i++) {
            key += ((char)('a' + i)).ToString() + ((char)(charCounts[i])).ToString();
        }

        return key;
    }
}
