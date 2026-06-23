from collections import Counter

class Solution:
    def majorityElement(self, nums: List[int]) -> List[int]:
        counts = Counter(nums)
        result = []

        for key, value in counts.items():
            if value > len(nums) / 3:
                result.append(key)
        
        return result
