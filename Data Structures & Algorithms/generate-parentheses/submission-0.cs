public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> res = new List<string>();
        BackTrack(n, 0, 0, "", res);
        return res;
    }

    private void BackTrack(int n, int open, int close, string current, List<string> res) {
        if (open == close && open == n) {
            res.Add(current);
            return;
        }

        if (open < n) {
            BackTrack(n, open+1, close, current + "(", res);
        }
        if (close < open) {
            BackTrack(n, open, close+1, current + ")", res);
        }
    }
}
