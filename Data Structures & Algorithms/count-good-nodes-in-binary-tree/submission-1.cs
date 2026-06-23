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
    int goodNodes = 0;

    public int GoodNodes(TreeNode root) {
        Dfs(root, root.val);
        return goodNodes;
    }

    private void Dfs(TreeNode root, int maxSoFar) {
        if (root == null) {
            return;
        }

        if (root.val >= maxSoFar) {
            goodNodes++;
        }

        int max = Math.Max(root.val, maxSoFar);
        Dfs(root.left, max);
        Dfs(root.right, max);
        return;
    }
}
