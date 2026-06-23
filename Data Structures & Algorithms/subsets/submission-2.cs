public class Solution {
    List<List<int>> res = new List<List<int>>();
    List<int> subset = new List<int>();

    public List<List<int>> Subsets(int[] nums) {
        Dfs(nums, 0);
        return res;
    }

    public void Dfs(int[] nums, int i) {
        if (i >= nums.Length) {
            res.Add(new List<int>(subset));
            return;
        }

        // Decision to include index i in the subset
        subset.Add(nums[i]);
        Dfs(nums, i + 1);

        // Decision not to include index i
        subset.RemoveAt(subset.Count - 1);
        Dfs(nums, i + 1);
    }
}
