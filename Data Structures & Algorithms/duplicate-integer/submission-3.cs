public class Solution {
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numsSet = new HashSet<int>();

        foreach(var num in nums) {
            if (numsSet.Contains(num)) {
                return true;
            }

            numsSet.Add(num);
        }

        return false;
    }
}