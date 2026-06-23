public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        else if (nums.Length == 1) {
            return nums[0];
        }

        return Math.Max(Helper(nums[1..]), Helper(nums[..^1]));
    }

    private int Helper(int[] nums) {
        if (nums.Length == 0) {
            return 0;
        }
        else if (nums.Length == 1) {
            return nums[0];
        }

        int n = nums.Length;
        int[] maxRob = new int[n];
        maxRob[0] = nums[0];
        maxRob[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < n; i++) {
            maxRob[i] = Math.Max(maxRob[i - 1], nums[i] + maxRob[i - 2]);
        }

        return maxRob[n-1];
    }
}
