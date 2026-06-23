public class Solution {
    List<List<int>> res = new List<List<int>>();
    
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<int> subset = new List<int>();
        Array.Sort(nums);
        Backtrack(nums, 0, subset);
        return res;
    }

    private void Backtrack(int[] nums, int i, List<int> subset) {
        if (i == nums.Length) {
            res.Add(new List<int>(subset));
            return;
        }

        subset.Add(nums[i]);
        Backtrack(nums, i + 1, subset);
        subset.RemoveAt(subset.Count - 1);

        while ((i + 1) < nums.Length && nums[i] == nums[i + 1]) {
            i++;
        }
        Backtrack(nums, i + 1, subset);
    }
}
