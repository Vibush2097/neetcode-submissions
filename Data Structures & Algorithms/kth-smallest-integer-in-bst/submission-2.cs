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
    public int KthSmallest(TreeNode root, int k) {
        List<int> inOrder = new List<int>();
        InOrder(root, inOrder);

        for (int i = 0; i < inOrder.Count; i++) {
            --k;

            if (k == 0) {
                return inOrder[i];
            }
        }

        return -1;
    }

    private void InOrder(TreeNode root, IList<int> res) {
        if (root == null) {
            return;
        }

        InOrder(root.left, res);
        res.Add(root.val);
        InOrder(root.right, res);
    }
}
