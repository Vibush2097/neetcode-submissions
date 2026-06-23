public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>(nums);

        int sequence = 0, maxSequence = 0;

        // Any number in the array that doesn't have num[i]-1 is a starting number
        // Check each staring number for the longest sequence
        for (int i = 0; i < nums.Length; i++) {
            if (numSet.Contains(nums[i] - 1)) continue;
            
            sequence = 1;
            while (numSet.Contains(nums[i] + sequence)) {
                sequence++;
            }

            maxSequence = Math.Max(sequence, maxSequence);
        }

        return maxSequence;
    }
}
