public class Solution {
    List<List<int>> res = new List<List<int>>();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<int> combination = new List<int>();
        Combination(nums, 0, combination, target);
        return res;
    }

    public void Combination(int[] nums, int i, List<int> combination, int target) {
        if (target == 0) {
            res.Add(new List<int>(combination));
            return;
        }

        if (i >= nums.Length || target < 0) {
            return;
        }

        // Choose to include index i
        combination.Add(nums[i]);
        Combination(nums, i, combination, target - nums[i]);

        // Choose not to include index i and move to index i + 1
        combination.RemoveAt(combination.Count - 1);
        Combination(nums, i + 1, combination, target);
    }
}
