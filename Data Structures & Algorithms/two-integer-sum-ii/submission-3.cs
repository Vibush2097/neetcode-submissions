public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int l = 0, r = n - 1;
        int curSum = 0;

        while (l < r) {
            curSum = numbers[l] + numbers[r];

            if (curSum > target) {
                r--;
            }
            else if (curSum < target) {
                l++;
            }
            else {
                return new int[] {l + 1, r + 1};
            }
        }

        return new int[]{};
    }
}
