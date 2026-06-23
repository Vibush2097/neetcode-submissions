class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        indices = {}

        for i in range(len(nums)):
            if nums[i] not in indices:
                indices[nums[i]] = [i]
            else:
                indices[nums[i]].append(i)

        for i in range(0, len(nums)):
            remain = target - nums[i]
            if remain in indices:
                for j in indices[remain]:
                    if i != j:
                        return [i, j]
        
        return [-1, -1]
