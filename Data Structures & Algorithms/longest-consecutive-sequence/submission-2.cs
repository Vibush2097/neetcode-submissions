public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();

        // Store each num in a HashMap
        // O(n) extra space
        foreach (var num in nums) {
            if (!numSet.Contains(num)) {
                numSet.Add(num);
            }
        }

        List<int> startingNums = new List<int>();

        // Identify starting numbers in the sequence
        // O(n)
        for (int i = 0; i < nums.Length; i++) {
            if (numSet.Contains(nums[i] - 1)) continue;
            startingNums.Add(nums[i]);
        }

        int sequence = 0, maxSequence = 0;

        // Find the longest sequence
        // O(n)
        foreach (var num in startingNums) {
            Console.WriteLine($"Num: {num}");
            int start = num;
            sequence = 1;
            while (numSet.Contains(start + 1)) {
                sequence++;
                start++;
            }

            maxSequence = Math.Max(sequence, maxSequence);
        }

        return maxSequence;
    }
}
