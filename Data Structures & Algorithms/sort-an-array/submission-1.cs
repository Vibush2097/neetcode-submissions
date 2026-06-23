public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    public static void MergeSort(int[] arr, int l, int r) {
        if (l < r) {
            // Find the middle point
            int m = l + (r - l) / 2;

            // Sort the first and second halves
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            // Merge the Sorted halfs
            Merge(arr, l, m, r);
        }
    }

    public static void Merge(int[] arr, int l, int m, int r) {
        int size1 = m - l + 1;
        int size2 = r - m;

        int[] L = new int[size1];
        int[] R = new int[size2];

        int i, j;

        for (i = 0; i < size1; i++) {
            L[i] = arr[i + l];
        }
        for (j = 0; j < size2; j++) {
            R[j] = arr[j + m + 1];
        }

        int k = l;
        i = 0;
        j = 0;

        while (i < size1 && j < size2) {
            if (L[i] < R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < size1) {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < size2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}