class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        
        result = []
        current = []
        usedNums = set()

        def backtrack():
            if len(current) == len(nums):
                result.append(list(current))
                return

            for n in nums:
                if n not in usedNums:
                    current.append(n)
                    usedNums.add(n)
                    backtrack()
                    current.pop()
                    usedNums.remove(n)
            return

        backtrack()
        return result
