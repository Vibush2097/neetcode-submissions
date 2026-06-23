public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length, cols = matrix[0].Length;
        int len = rows * cols;
        int l = 0, r = len - 1, m;

        while (l <= r) {
            m = l + (r - l) / 2;
            int row = m / cols;
            int col = m % cols;

            if (matrix[row][col] == target) {
                return true;
            }
            else if (matrix[row][col] > target) {
                r = m - 1;
            }
            else {
                l = m + 1;
            }
        }

        return false;
    }
}
