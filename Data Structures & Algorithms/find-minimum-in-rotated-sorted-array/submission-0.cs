public class Solution {
    public int FindMin(int[] nums) {
        int left = 0, right = nums.Length-1;
        int mid;

        while (left <= right) {
            if (nums[left] <= nums[right]) {
                return nums[left];
            }

            mid = (left + right)/2;

            if (nums[mid] >= nums[left]) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }

        return -1;
    }
}
