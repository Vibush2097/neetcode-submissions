public class Solution {
    List<List<int>> res = new List<List<int>>();

    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<int> combination = new List<int>();
        Combination(candidates, 0, combination, target);
        var seen = new HashSet<string>();
        List<List<int>> final = new List<List<int>>();
        foreach (var list in res) {
            string key = string.Join(",", list);
            if (!seen.Contains(key)) {
                seen.Add(key);
                final.Add(list);
            }    
        }
        return final;
    }

    public void Combination(int[] nums, int i, List<int> combination, int target) {
        if (target == 0) {
            res.Add(new List<int>(combination));
        }

        if (i >= nums.Length || target < 0) {
            return;
        }

        // Include index i and move to i + 1
        combination.Add(nums[i]);
        Combination(nums, i + 1, combination, target - nums[i]);

        // Exclude index i and move to i + 1
        combination.RemoveAt(combination.Count - 1);
        Combination(nums, i + 1, combination, target);
    }
}
