public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();

        int i = 0;
        int cur = 0;
        while (i < nums.Length && nums[i] <= 0) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                i++;
                continue;
            }
            int l = i + 1, r = nums.Length - 1;

            while (l < r) {
                cur = nums[i] + nums[l] + nums[r];

                if (cur < 0) {
                    l++;
                }
                else if (cur > 0) {
                    r--;
                }
                else {
                    result.Add(new List<int> {nums[i], nums[l], nums[r]});

                    l++;
                    while (l < r && nums[l] == nums[l - 1]) {
                        l++;
                    }
                    r--;
                }
            }

            i++;
        }

        return result;
    }
}
