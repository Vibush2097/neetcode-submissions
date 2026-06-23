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
    public bool IsValidBST(TreeNode root) {
        var inOrder = new List<int>();
        InOrder(root, inOrder);

        for (int i = 0; i < inOrder.Count - 1; i++) {
            if (inOrder[i] >= inOrder[i + 1]) {
                return false;
            }
        }
        return true;
    }

    // For a valid BST, the inorder traversal should be strictly increasing
    public void InOrder(TreeNode root, IList<int> result) {
        if (root == null) {
            return;
        }

        InOrder(root.left, result);
        result.Add(root.val);
        InOrder(root.right, result);
    }
}
