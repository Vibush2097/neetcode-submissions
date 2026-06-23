# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:   
    def isSubtree(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:
        if not subRoot:
            return True
        if not root:
            return False

        # if root.val == subRoot.val and self.checkSubroot(root, subRoot):
        #     return True
        # return self.isSubtree(root.left, subRoot) or self.isSubtree(root.right, subRoot)
        stack = [root]

        while stack:
            top = stack.pop()
            print(top.val)
            if top.val == subRoot.val:
                result = self.checkSubroot(top, subRoot)
                if result:
                    return True
            
            if top.left:
                stack.append(top.left)
            if top.right:
                stack.append(top.right)

        return False

    def checkSubroot(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:
        if not root and not subRoot:
            return True
        if root and subRoot and root.val == subRoot.val:
            return self.checkSubroot(root.left, subRoot.left) and self.checkSubroot(root.right, subRoot.right)
        else:
            return False
            