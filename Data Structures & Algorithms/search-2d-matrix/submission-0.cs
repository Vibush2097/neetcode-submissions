public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // Brute force solution
        int m = matrix.Length;
        int n = matrix[0].Length;
        int[] matrixArray = new int[m * n];

        for (int i=0; i<m; i++) {
            for (int j=0; j<n; j++) {
                matrixArray[n*i + j] = matrix[i][j];
            }
        }

        int l=0, r = m*n-1;
        int mid;

        while (l <= r) {
            mid = l + (r-l)/2;

            if (matrixArray[mid] == target)
                return true;
            else if (matrixArray[mid] < target) {
                l = mid+1;
            }
            else {
                r = mid-1;
            }
        }

        return false;
    }
}
