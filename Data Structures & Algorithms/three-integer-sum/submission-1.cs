public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int l, r;
        List<List<int>> result = new List<List<int>>();

        for (int i=0; i<nums.Length; i++) {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i]==nums[i-1])
                continue;

            l = i+1;
            r = nums.Length-1;

            while (l < r) {
                int threeSum = nums[i] + nums[l] + nums[r];

                if (threeSum > 0)
                    r--;
                else if (threeSum < 0)
                    l++;
                else {
                    result.Add(new List<int> {nums[i], nums[l], nums[r]});
                    l++;
                    r--; // This isn't needed but if I already have (l,r) in the solution
                    // I can't have r again if l increments
                    while (l<r && nums[l]==nums[l-1]) {
                        l++;
                    }
                }        
            }
        }

        return result;
    }
}
