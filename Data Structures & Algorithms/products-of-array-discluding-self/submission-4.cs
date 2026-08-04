public class Solution {
    // Time Complexity: o(n)
    // Space Complexity: O(n)
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] forwardProduct = new int[n];
        int[] backwardProduct = new int[n];
        forwardProduct[0] = 1;
        backwardProduct[n - 1] = 1;
        int prev = forwardProduct[0];

        for (int i = 1; i < n; i++) {
            forwardProduct[i] = prev * nums[i - 1];
            prev = forwardProduct[i];
        }

        prev = 1;
        for (int i = n - 2; i >= 0; i--) {
            backwardProduct[i] = prev * nums[i + 1];
            prev = backwardProduct[i];
        }

        int[] result = new int[n];

        for (int i = 0; i < n; i++) {
            result[i] = forwardProduct[i] * backwardProduct[i];
        }

        return result;
    }
}
