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
    public List<int> RightSideView(TreeNode root) {
        if (root == null) {
            return new List<int>();
        }

        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        Queue<(TreeNode, int)> q = new Queue<(TreeNode, int)>();
        int maxLevel = 0;

        q.Enqueue((root, 0));

        while (q.Count > 0) {
            var pair = q.Dequeue();
            TreeNode node = pair.Item1;
            int level = pair.Item2;
            maxLevel = Math.Max(level, maxLevel);

            if (!dict.ContainsKey(level)) {
                dict[level] = new List<int>();
            }
            dict[level].Add(node.val);

            if (node.left != null) {
                q.Enqueue((node.left, level + 1));
            }
            if (node.right != null) {
                q.Enqueue((node.right, level + 1));
            }
        }

        List<int> res = new List<int>();

        for (int i = 0; i <= maxLevel; i++) {
            res.Add(dict[i][dict[i].Count - 1]);
        }

        return res;
    }
}
