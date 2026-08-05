public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<int>[] rows = new HashSet<int>[9];
        HashSet<int>[] cols = new HashSet<int>[9];
        Dictionary<(int, int), HashSet<int>> grid = new Dictionary<(int, int), HashSet<int>>();

        for (int i = 0; i < 9; i++) {
            rows[i] = new HashSet<int>();
            cols[i] = new HashSet<int>();

            for (int j = 0; j < 9; j++) {
                int rowKey = i/3;
                int colKey = j/3;

                if (!grid.ContainsKey((rowKey, colKey))) {
                    grid[(rowKey, colKey)] = new HashSet<int>();
                }
            }
        }

        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.')
                    continue;
                
                int num = board[i][j] - '0';
                int rowKey = i/3;
                int colKey = j/3;

                if (rows[i].Contains(num))
                    return false;
                if (cols[j].Contains(num))
                    return false;
                if (grid[(rowKey, colKey)].Contains(num))
                    return false;
                
                rows[i].Add(num);
                cols[j].Add(num);
                grid[(rowKey, colKey)].Add(num);
            }
        }

        return true;
    }
}
