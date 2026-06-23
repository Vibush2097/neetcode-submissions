// Recursive Solution
// public class Solution {
//     public List<List<int>> Permute(int[] nums) {
//         if (nums.Length == 0) {
//             return new List<List<int>> { new List<int>() };
//         }

//         var perms = Permute(nums[1..]);
//         var res = new List<List<int>>();
//         foreach (var p in perms) {
//             for (int i = 0; i <= p.Count; i++) {
//                 var p_copy = new List<int>(p);
//                 p_copy.Insert(i, nums[0]);
//                 res.Add(p_copy);
//             }
//         }

//         return res;
//     }
// }

// Iterative Solution
// public class Solution {
//     public List<List<int>> Permute(int[] nums) {
//         if (nums.Length == 0) {
//             return new List<List<int>> { new List<int>() };
//         }

//         var perms = new List<List<int>> { new List<int>() };

//         foreach (var n in nums) {
//             var new_perms = new List<List<int>>();
//             foreach (var p in perms) {
//                 for (int i = 0; i <= p.Count; i++) {
//                     var p_copy = new List<int>(p);
//                     p_copy.Insert(i, n);
//                     new_perms.Add(p_copy);
//                 }
//             }
//             perms = new_perms;
//         }

//         return perms;
//     }
// }

// Backtracking Solution
public class Solution {
    List<List<int>> res;

    public List<List<int>> Permute(int[] nums) {
        res = new List<List<int>>();
        Backtrack(new List<int>(), nums, new bool[nums.Length]);
        return res;
    }

    private void Backtrack(List<int> perm, int[] nums, bool[] picks) {
        if (perm.Count == nums.Length) {
            res.Add(new List<int>(perm));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (!picks[i]) {
                perm.Add(nums[i]);
                picks[i] = true;
                Backtrack(perm, nums, picks);
                perm.RemoveAt(perm.Count - 1);
                picks[i] = false;
            }
        }
    }
}
