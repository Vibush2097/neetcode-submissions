class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        forward = list(nums)
        backward = list(nums)

        forward[0] = 1
        backward[-1] = 1
        
        prev = 1
        for i in range(1, len(forward)):
            prev = prev * nums[i-1]
            forward[i] = prev

        prev = 1
        for i in range(len(backward) - 2, -1, -1):
            prev = prev * nums[i+1]
            backward[i] = prev

        for i in range(len(nums)):
            nums[i] = forward[i] * backward[i]
        
        return nums