public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        numDict[nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++) {
            if (numDict.TryGetValue(target - nums[i], out int value)) {
                return new int[] { value, i };
            }
            numDict[nums[i]] =  i;
        }

        return new int[] {-1,  -1};
    }
}
