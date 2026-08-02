public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pos = new Dictionary<int, int>();
        pos.Add(nums[0], 0);

        for (int i = 1; i < nums.Length; i++) {
            int diff = target - nums[i];

            if (pos.ContainsKey(diff) && pos[diff] != i) {
                return new int[] {pos[diff], i};
            }

            pos.Add(nums[i], i);
        }

        return new int[] {-1, -1};
    }
}
