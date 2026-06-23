public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1,  m;

        while (l < r) {
            m = l + (r - l) / 2;

            if (nums[m] < target) {
                l = m + 1;
            }
            else {
                r = m;
            }
        }

        if (l == nums.Length - 1 && nums[l] < target) {
            l++;
        }

        return l;
    }
}