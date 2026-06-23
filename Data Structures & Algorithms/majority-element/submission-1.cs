public class Solution {
    // Solution with O(n) extra space
    // public int MajorityElement(int[] nums) {
    //     Dictionary<int, int> dict = new Dictionary<int, int>();

    //     foreach (int num in nums) {
    //         if (!dict.ContainsKey(num)) {
    //             dict[num] = 0;
    //         }
    //         dict[num]++;

    //         if (dict[num] > nums.Length / 2) {
    //             return num;
    //         }
    //     }

    //     return -1;
    // }

    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (count == 0) {
                candidate = nums[i];
            }

            count += (nums[i] == candidate) ? 1 : -1;
        }

        return candidate;
    }
}