public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            hs.Add(nums[i]);
        }

        return hs.Count < nums.Length;
    }
}