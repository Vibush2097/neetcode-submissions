public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] count = new int[26];

            for (int i=0; i<s.Length; i++) {
                count[s[i]-'a']++;
            }

            string key = string.Join(',', count);

            if (!dict.ContainsKey(key))
                dict[key] = new List<string>();
            dict[key].Add(s);
        }

        return new List<List<string>>(dict.Values);
    }
}
