public class Solution {
    public int Search(int[] nums, int target) {
        int start = -1;

        int l=0, r = nums.Length-1;
        int m;

        while (l<=r) {
            if (nums[l] <= nums[r]) {
                start = l;
                break;
            }

            m = (l+r)/2;

            if (nums[m] >= nums[l])
                l = m + 1;
            else
                r = m;
        }

        l = start;
        r = start - 1 < 0 ? nums.Length - 1 : start - 1;
        int origL = 0;
        int origR = nums.Length - 1;
        int origM;

        while (origL <= origR) {
            origM = (origL + origR) / 2;
            m = (origM + start) % nums.Length;

            if (nums[m] == target)
                return m;
            else if (nums[m] < target) {
                l = (m + 1) % nums.Length;
                origL = origM + 1;
            }
            else {
                r = (m-1) % nums.Length;
                r = r < 0 ? nums.Length - 1 : r;
                origR = origM - 1;
            }
        }

        return -1;
    }
}
