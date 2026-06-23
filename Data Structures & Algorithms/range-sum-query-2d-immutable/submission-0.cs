public class NumMatrix {
    private int[,] prefixMat;

    public NumMatrix(int[][] matrix) {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;
        prefixMat = new int[ROWS + 1, COLS + 1];

        for (int r = 0; r < ROWS; r++) {
            int prefix = 0;
            for (int c = 0; c < COLS; c++) {
                prefix += matrix[r][c];
                int above = prefixMat[r, c + 1];
                prefixMat[r + 1, c + 1] = prefix + above;
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        row1++; col1++; row2++; col2++;
        int bottomRight = prefixMat[row2, col2];
        int above = prefixMat[row1 - 1, col2];
        int left = prefixMat[row2, col1 - 1];
        int topLeft = prefixMat[row1 - 1, col1 - 1];
        return bottomRight - above - left + topLeft;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */

 /*
    0 0 0 0 0 0
    0 3 0 1 4 2
    0 5 6 3 2 1
    0 1 2 0 1 5
    0 4 1 0 1 7
    0 1 0 3 0 5
 */