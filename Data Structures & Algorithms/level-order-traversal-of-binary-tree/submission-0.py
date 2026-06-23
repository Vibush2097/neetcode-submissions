# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        if not root:
            return []

        levels = {}
        level = 0
        q = [[root, 0]]

        while q:
            front, level = q.pop(0)

            if not level in levels:
                levels[level] = []
            levels[level].append(front.val)

            if front.left:
                q.append([front.left, 1 + level])
            if front.right:
                q.append([front.right, 1 + level])
        
        result = []

        for key, value in levels.items():
            result.append(value)
        
        return result

