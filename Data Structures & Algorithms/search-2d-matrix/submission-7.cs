public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int l = 0 , r = rows * cols - 1, m;

        while (l <= r) {
            m = (l + r) / 2;
            int x = m / cols;
            int y = m % cols;
            int val = matrix[x][y];
            Console.WriteLine($"{x} {y} {val}");

            if (val == target) {
                return true;
            }
            else if (val > target) {
                r = m - 1;
            }
            else {
                l = m + 1;
            }
        }

        return false;
    }
}
