public class Solution {
    public void SortColors(int[] nums) {
        int swap0 = 0, swap2 = nums.Length - 1;
        int temp = 0, i = 0;

        while (i <= swap2) {
            if (nums[i] == 0) {
                temp = nums[i];
                nums[i] = nums[swap0];
                nums[swap0] = temp;
                swap0++;
            }
            else if (nums[i] == 2) {
                temp = nums[i];
                nums[i] = nums[swap2];
                nums[swap2] = temp;
                swap2--;
                i--;
            }
            i++;
        }
    }
}