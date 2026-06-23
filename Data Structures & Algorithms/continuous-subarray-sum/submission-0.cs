public class Solution {
    // Brute Force
    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    // public bool CheckSubarraySum(int[] nums, int k) {
    //     int sum;

    //     for (int i = 0; i < nums.Length; i++) {
    //         sum = nums[i];
    //         for (int j = i + 1; j < nums.Length; j++) {
    //             sum += nums[j];

    //             if (sum % k == 0) {
    //                 return true;
    //             }
    //         }
    //     }

    //     return false;
    // }

    // Optimal
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public bool CheckSubarraySum(int[] nums, int k) {
        if (nums.Length == 1) {
            return false;
        }

        int total = 0;
        Dictionary<int, int> remainderIndex = new Dictionary<int, int>();
        remainderIndex[0] = -1;

        for (int i = 0; i < nums.Length; i++) {
            total += nums[i];
            int remainder = total % k;

            if (!remainderIndex.ContainsKey(remainder)) {
                remainderIndex[remainder] = i;
            }
            else if(i - remainderIndex[remainder] > 1) {
                return true;
            }
        }

        return false;
    }
}