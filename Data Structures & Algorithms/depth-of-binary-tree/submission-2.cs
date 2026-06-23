/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// Recursive Solution
// public class Solution {
//     public int MaxDepth(TreeNode root) {
//         if (root == null)
//             return 0;
        
//         return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
//     }
// }

// Iterative DFS Solution
public class Solution {
    public int MaxDepth(TreeNode root) {
        Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
        stack.Push(new Tuple<TreeNode, int>(root, 1));
        int res = 0;

        while (stack.Count > 0) {
            var top = stack.Pop();
            var node = top.Item1;
            var depth = top.Item2;

            if (node != null) {
                res = Math.Max(res, depth);
                stack.Push(new Tuple<TreeNode, int>(node.left, depth + 1));
                stack.Push(new Tuple<TreeNode, int>(node.right, depth + 1));
            }
        }

        return res;
    }
}

