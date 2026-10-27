public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        int[] counts = new int[26];
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            string current = strs[i];
            for (int j = 0; j < 26; j++) {
                counts[j] = 0;
            }

            for (int j = 0; j < current.Length; j++) {
                counts[current[j] - 'a']++;
            }
            string key = BuildKey(counts);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(strs[i]);
        }

        return dict.Values.ToList();
    }

    private string BuildKey(int[] counts) {
        StringBuilder keyBuilder = new StringBuilder();

        for (int i = 0; i < 26; i++) {
            char letter = (char)('a' + i);
            keyBuilder.Append(letter).Append(counts[i]);
        }
        return keyBuilder.ToString();
    }
}
