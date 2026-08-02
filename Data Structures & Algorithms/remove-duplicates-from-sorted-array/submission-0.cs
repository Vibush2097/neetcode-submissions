public class Solution {
    // Solution with O(1) extra space
    // Does not modify the array in place
    // public int RemoveDuplicates(int[] nums) {
    //     int[] counts = new int[201];

    //     for (int i = 0; i < nums.Length; i++) {
    //         counts[100 + nums[i]]++;
    //     }

    //     int idx = 0;
    //     for (int i = -100; i <= 100; i++) {
    //         if (counts[100 + i] != 0) {
    //             nums[idx] = i;
    //             idx++;
    //         }
    //     }

    //     return idx;
    // }

    public int RemoveDuplicates(int[] nums) {
        int l = 0;
        int r = 0;
        int n = nums.Length;

        while (r < n) {
            nums[l] = nums[r];
            while (r < n && nums[l] == nums[r]) {
                r++;
            }
            l++;
        }

        return l;
    }
}