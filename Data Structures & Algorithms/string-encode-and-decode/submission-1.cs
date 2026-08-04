public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach (var s in strs) {
            encoded += (s.Length).ToString() + "#" + s;
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length) {
            string num = "";

            while (int.TryParse(s[i].ToString(), out int n)) {
                num += s[i];
                i++;
            }

            bool convert = int.TryParse(num, out int k);

            if (convert) {
                i++;
                result.Add(s.Substring(i, k));
            }
            i += k;
        }

        return result;
    }
}
