public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1) {
            return nums[0];
        }
        else if (nums.Length == 2) {
            return Math.Max(nums[0], nums[1]);
        }

        int[] maxRob = new int[nums.Length];
        Array.Fill(maxRob, -1);
        maxRob[0] = nums[0];
        maxRob[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++) {
            maxRob[i] = Math.Max(maxRob[i-1], nums[i] + maxRob[i-2]);
            Console.WriteLine($"cur value: {maxRob[i]}");
        }

        return maxRob[nums.Length - 1];
    }
}
