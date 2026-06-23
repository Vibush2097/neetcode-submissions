public class Solution {
    // Brute Force
    // Time Complexity: O(n^4)
    // public List<List<int>> FourSum(int[] nums, int target) {
    //     if (nums.Length < 4)
    //         return new List<List<int>>();

    //     Array.Sort(nums);
    //     List<List<int>> result = new List<List<int>>();
    //     HashSet<string> keys = new HashSet<string>();

    //     for (int i = 0; i < nums.Length; i++) {
    //         for (int j = i + 1; j < nums.Length; j++) {
    //             for (int k = j + 1; k < nums.Length; k++) {
    //                 for (int l = k + 1; l < nums.Length; l++) {
    //                     int sum = nums[i] + nums[j] + nums[k] + nums[l];
    //                     string key = nums[i].ToString() + ":" + nums[j].ToString() + ":" + nums[k].ToString() + ":" + nums[l].ToString();

    //                     if (sum == target && !keys.Contains(key)) {
    //                         keys.Add(key);
    //                         result.Add(new List<int> {nums[i], nums[j], nums[k], nums[l]});
    //                     }
    //                 }
    //             }
    //         }
    //     }

    //     return result;
    // }

    public List<List<int>> FourSum(int[] nums, int target) {
        if (nums.Length < 4)
            return new List<List<int>>();

        Array.Sort(nums);
        List<List<int>> result = new List<List<int>>();
        HashSet<string> keys = new HashSet<string>();

        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                long rem = (long)target - (long)nums[i] - (long)nums[j];
                int l = j + 1, r = nums.Length - 1;

                while (l < r) {
                    long sum = (long)nums[l] + (long)nums[r];

                    if (sum == rem) {
                        string key = nums[i].ToString() + ":" + nums[j].ToString() + ":" + nums[l].ToString() + ":" + nums[r].ToString();

                        if (!keys.Contains(key)) {
                            keys.Add(key);
                            result.Add(new List<int> {nums[i], nums[j], nums[l], nums[r]});
                        }

                        l++;
                        r--;

                        while (l < r && nums[l] == nums[l - 1]) {
                            l++;
                        }
                    }
                    else if (sum > rem) {
                        r--;
                    }
                    else {
                        l++;
                    }
                }
            }
        }

        return result;
    }
}