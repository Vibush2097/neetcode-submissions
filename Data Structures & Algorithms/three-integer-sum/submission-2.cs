public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); // In-place array sort
        int i = 0, j, k;

        if (nums[i] > 0) {
            return new List<List<int>>();
        }

        List<List<int>> res = new List<List<int>>();

        for (i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i-1]) continue;

            j = i + 1;
            k = nums.Length - 1;

            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];

                if (sum == 0) {
                    res.Add(new List<int> {nums[i], nums[j], nums[k]});
                    j++;
                    k--;
                    while (j < k && nums[j] == nums[j-1]) {
                        j++;
                    }
                }
                else if (sum > 0) {
                    k--;
                }
                else {
                    j++;
                }
            }
        }

        return res;
    }
}
