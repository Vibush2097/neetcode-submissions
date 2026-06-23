// // Solution with Backtracking
// public class Solution {
//     List<List<int>> res;

//     public List<List<int>> CombinationSum(int[] nums, int target) {
//         res = new List<List<int>>();
//         Backtrack(0, new List<int>(), 0, nums, target);
//         return res;
//     }

//     public void Backtrack(int i, List<int> cur, int total, int[] nums, int target) {
//         if (total == target) {
//             res.Add(cur.ToList());
//             return;
//         }

//         if (i >= nums.Length || total > target) {
//             return;
//         }

//         cur.Add(nums[i]);
//         Backtrack(i, cur, total + nums[i], nums, target);
//         cur.Remove(cur.Last());
//         Backtrack(i + 1, cur, total, nums, target);
//     }
// }

// Optimal Solution with Backtracking
public class Solution {
    List<List<int>> res;

    public List<List<int>> CombinationSum(int[] nums, int target) {
        res = new List<List<int>>();
        Array.Sort(nums);
        Backtrack(0, new List<int>(), 0, nums, target);
        return res;
    }

    public void Backtrack(int i, List<int> cur, int total, int[] nums, int target) {
        if (total == target) {
            res.Add(cur.ToList());
            return;
        }

        for (int j = i; j < nums.Length; j++) {
            if (total + nums[j] > target) {
                return;
            }

            cur.Add(nums[j]);
            Backtrack(j, cur, total + nums[j], nums, target);
            cur.Remove(cur.Last());
        }
    }
}
