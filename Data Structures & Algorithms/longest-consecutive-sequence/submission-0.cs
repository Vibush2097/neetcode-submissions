public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length < 1)
            return nums.Length;

        HashSet<int> numSet = new HashSet<int>(nums);

        int longest = 0;

        foreach (var n in numSet) {
            if (!numSet.Contains(n-1)) {
                int len = 1;

                while(numSet.Contains(n+len)) {
                    len++;
                }

                longest = len > longest ? len : longest;
            }
        }

        return longest;
    }
}
