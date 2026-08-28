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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0) {
            TreeNode node = stack.Pop();

            if (IsSame(node, subRoot)) {
                return true;
            }

            if (node.left != null) {
                stack.Push(node.left);
            }

            if (node.right != null) {
                stack.Push(node.right);
            }
        }

        return false;
    }

    private bool IsSame(TreeNode root, TreeNode subRoot) {
        if (root == null || subRoot == null) {
            if (root != null || subRoot != null) {
                return false;
            }

            return true;
        }

        if (root.val != subRoot.val) {
            return false;
        }

        return IsSame(root.left, subRoot.left) && IsSame(root.right, subRoot.right);
    }
}
