public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1;
        int m;

        while (l <= r) {
            m = (l+ r) / 2;

            Console.WriteLine($"{l} {m} {r}");

            if (nums[m] >= nums[r]) {
                l = m + 1;
            }
            else {
                r = m;
            }
        }

        return nums[r];
    }
}

// 3 4 5 6 1 2
// l = 0, r = 5
// m = 2

// l = 3, r = 5
// m = 4