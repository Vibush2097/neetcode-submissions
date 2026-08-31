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
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root == null) {
            return new List<List<int>>();
        }
        
        Dictionary<int, List<int>> levels = new Dictionary<int, List<int>>();
        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 0));

        while (queue.Count > 0) {
            (TreeNode node, int level) = queue.Dequeue();
            if (!levels.ContainsKey(level)) {
                levels[level] = new List<int>();
            }

            levels[level].Add(node.val);

            if (node.left != null) {
                queue.Enqueue((node.left, level + 1));
            }

            if (node.right != null) {
                queue.Enqueue((node.right, level + 1));
            }
        }

        return levels.Values.ToList();
    }
}
