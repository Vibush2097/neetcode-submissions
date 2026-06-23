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

public class Solution {
    // Recursive Solution
    // public int MaxDepth(TreeNode root) {
    //     if (root == null) {
    //         return 0;
    //     }

    //     return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
    // }

    public int MaxDepth(TreeNode root) {
        Stack<Tuple<TreeNode, int>> stack = new Stack<Tuple<TreeNode, int>>();
        stack.Push(new Tuple<TreeNode, int>(root, 1));
        int res = 0;

        while (stack.Count > 0) {
            var top = stack.Pop();
            TreeNode node = top.Item1;
            int depth = top.Item2;

            if (node != null) {
                res = Math.Max(res, depth);
                stack.Push(new Tuple<TreeNode, int>(node.left, 1 + depth));
                stack.Push(new Tuple<TreeNode, int>(node.right, 1 + depth));
            }
        }

        return res;
    }
}
