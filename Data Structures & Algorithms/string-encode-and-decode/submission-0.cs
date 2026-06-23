public class Solution {

    public string Encode(IList<string> strs) {
        return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        
        var i=0;
        while (i < s.Length) {
            var j = i;
            while (s[j] != '#') {
                ++j;
            }

            int.TryParse(s.Substring(i, j-i), out var len);
            j++;
            result.Add(s.Substring(j, len));
            i = j + len;
        }
        return result;
   }
}
