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
    // O(n^2) solution
    // public TreeNode BuildTree(int[] preorder, int[] inorder) {
    //     if (preorder.Length == 0 || inorder.Length == 0) {
    //         return null;
    //     }

    //     TreeNode root = new TreeNode(preorder[0]);
    //     int mid = Array.IndexOf(inorder, preorder[0]);
    //     root.left = BuildTree(preorder.Skip(1).Take(mid).ToArray(), inorder.Take(mid).ToArray());
    //     root.right = BuildTree(preorder.Skip(mid + 1).ToArray(), inorder.Skip(mid + 1).ToArray());
    //     // For right we skip mid + 1 because we skip root (1 value) + left subtree (mid values)
    //     return root;
    // }

    // O(n) solution
    int pre_idx = 0;
    Dictionary<int, int> pos = new Dictionary<int, int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++) {
            pos[inorder[i]] = i;
        }

        return Dfs(preorder, 0, inorder.Length - 1);
    }

    private TreeNode Dfs(int[] preorder, int l, int r) {
        if (l > r) {
            return null;
        }

        int root_val = preorder[pre_idx++];
        TreeNode root = new TreeNode(root_val);
        int mid = pos[root_val];
        root.left = Dfs(preorder, l, mid - 1);
        root.right = Dfs(preorder, mid + 1, r);
        return root;
    }
}
