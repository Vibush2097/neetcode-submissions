public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();

        for (int i=0; i<nums.Length; i++) {
            if (!hash.Contains(nums[i]))
                hash.Add(nums[i]);
            else
                return true;
        }
        return false;
    }
}
