public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> squares = new Dictionary<int, HashSet<char>>();

        for (int r = 0; r < 9; r++) {
            for (int c = 0; c < 9; c++) {
                char cell = board[r][c];
                int key = (r/3)*3 + c/3;

                if (cell == '.')
                    continue;

                if (rows.TryGetValue(r, out var rowSet) && rowSet.Contains(cell) ||
                    cols.TryGetValue(c, out var colSet) && colSet.Contains(cell) ||
                    squares.TryGetValue(key, out var squareSet) && squareSet.Contains(cell)) {
                        return false;
                    }

                cols.TryAdd(c, new HashSet<char>());
                rows.TryAdd(r, new HashSet<char>());
                squares.TryAdd(key, new HashSet<char>());

                cols[c].Add(cell);
                rows[r].Add(cell);
                squares[key].Add(cell);
            }
        }

        return true;
    }
}
