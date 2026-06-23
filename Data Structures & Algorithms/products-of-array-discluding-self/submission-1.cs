public class Solution {
    // Solution using the multiplication operator
    // Time Complexity : O(n)
    // Space Complexity : O(n)
    // public int[] ProductExceptSelf(int[] nums) {
    //     int[] productBackward = new int[nums.Length];
    //     int[] productForward = new int[nums.Length];
    //     int[] res = new int[nums.Length];

    //     productBackward[0] = 1;
    //     productForward[nums.Length - 1] = 1;

    //     for (int i = 1; i < nums.Length; i++) {
    //         productBackward[i] = productBackward[i - 1] * nums[i - 1];
    //     }

    //     for (int i = nums.Length - 2; i >= 0; i--) {
    //         productForward[i] = productForward[i + 1] * nums[i + 1];
    //     }

    //     for (int i = 0; i < nums.Length; i++) {
    //         res[i] = productBackward[i] * productForward[i];
    //     }

    //     return res;
    // }

    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        // res[0] = 1;
        // res[nums.Length - 1] = 1;
        int prev = 1;

        for (int i = 0; i < nums.Length; i++) {
            res[i] = prev;
            prev = prev * nums[i];
        }

        prev = nums[nums.Length - 1];
        for (int i = nums.Length - 2; i >= 0; i--) {
            res[i] = res[i] * prev;
            prev = prev * nums[i];
        }

        return res;
    }
    // [1, 1, 2, 1], prev = 8
}
