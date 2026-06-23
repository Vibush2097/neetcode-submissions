public class Solution {

    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int numIslands = 0;

        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i][j] == '1') {

                    Dfs(grid, i, j, m, n);
                    numIslands++;
                }
            }
        }

        return numIslands;
    }

    public void Dfs(char[][] grid, int i, int j, int m, int n) {
        if (!IsValidIndex(i, j, m, n) || grid[i][j] == '0') {
            return;
        }

        grid[i][j] = '0';

        int[] positions = new int[] {-1, 0, 1, 0, -1};

        for (int k = 0; k < 4; k++) {
            int row = i + positions[k];
            int col = j + positions[k + 1];
            Dfs(grid, row, col, m, n);
        }
    }

    private bool IsValidIndex(int i, int j, int m, int n) {
        if (i < 0 || j < 0 || i >= m || j >= n) {
            return false;
        }
        return true;
    }
}
