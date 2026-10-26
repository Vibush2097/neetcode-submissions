public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> pos = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (pos.ContainsKey(target - nums[i])) {
                return new int[] {pos[target - nums[i]], i};
            }
            pos[nums[i]] = i;
        }

        return new int[] {-1, -1};
    }
}
