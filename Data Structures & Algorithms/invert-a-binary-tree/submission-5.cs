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
    /*
        Solution with Recursion
        Time Complexity: O(n)
        Space Complexity: O(n)
    */
    // public TreeNode InvertTree(TreeNode root) {
    //     if (root == null) {
    //         return root;
    //     }

    //     TreeNode temp = root.right;
    //     root.right = root.left;
    //     root.left = temp;
    //     InvertTree(root.left);
    //     InvertTree(root.right);
    //     return root;
    // }

    /*
        Solution with Queue
        Time Complexity: O(n)
        Space Complexity: O(n)
    */
    public TreeNode InvertTree(TreeNode root) {
        if (root == null) {
            return root;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            TreeNode node = queue.Dequeue();
            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            if (node.left != null) 
                queue.Enqueue(node.left);
            
            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return root;
    }
}
