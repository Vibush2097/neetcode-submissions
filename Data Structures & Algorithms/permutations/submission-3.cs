public class Solution {
    // Recursion
    // public List<List<int>> Permute(int[] nums) {
    //     if (nums.Length == 0) {
    //         return new List<List<int>> { new List<int>() };
    //     }

    //     var perms = Permute(nums[1..]);
    //     var res = new List<List<int>>();
    //     foreach (var p in perms) {
    //         for (int i = 0; i <= p.Count; i++) {
    //             var p_copy = new List<int>(p);
    //             p_copy.Insert(i, nums[0]);
    //             res.Add(p_copy);
    //         }
    //     }
    //     return res;
    // }

    List<List<int>> res;

    // Backtracking
    public List<List<int>> Permute(int[] nums) {
        bool[] visited = new bool[nums.Length];
        var perm = new List<int>();
        res = new List<List<int>>();
        Permutations(nums, visited, perm);
        return res;
    }

    private void Permutations(int[] nums, bool[] visited, List<int> perm) {
        if (perm.Count == nums.Length) {
            res.Add(new List<int>(perm));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!visited[i]) {
                perm.Add(nums[i]);
                visited[i] = true;
                Permutations(nums, visited, perm);
                perm.RemoveAt(perm.Count - 1);
                visited[i] = false;
            }
        }
    }
}
