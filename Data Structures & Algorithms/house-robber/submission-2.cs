public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) {
            return nums[0];
        }

        int[] maxRob = new int[nums.Length];
        maxRob[0] = nums[0];
        maxRob[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++) {
            maxRob[i] = Math.Max(maxRob[i-1], nums[i] + maxRob[i-2]);
        }

        return maxRob[nums.Length - 1];
    }
}
