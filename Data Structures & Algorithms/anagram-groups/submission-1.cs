public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        int[] chars = new int[26];
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            string cur = strs[i];

            for (int j = 0; j < cur.Length; j++) {
                chars[cur[j] - 'a']++;
            }

            string key = "";
            for (int j = 0; j < 26; j++) {
                if (chars[j] > 0) {
                    key += (char)('a' + j) + chars[j].ToString();
                    chars[j] = 0;
                }
            }

            if (!anagramGroups.ContainsKey(key)) {
                anagramGroups[key] = new List<string>();
            }
            anagramGroups[key].Add(cur);
        }

        List<List<string>> groups = new List<List<string>>();

        foreach (var kvp in anagramGroups) {
            groups.Add(kvp.Value);
        }

        return groups;
    }
}
