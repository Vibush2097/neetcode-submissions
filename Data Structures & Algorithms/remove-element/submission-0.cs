public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int currentInsertPos = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == val) {
                count++;
            }
            else {
                nums[currentInsertPos] = nums[i];
                currentInsertPos++;
            }
        }

        return nums.Length - count;
    }
}