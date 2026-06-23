class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        res = 0
        curSum = 0
        prefixSums = { 0 : 1 }

        for n in nums:
            curSum += n
            diff = curSum - k
            res += prefixSums.get(diff, 0)
            prefixSums[curSum] = 1 + prefixSums.get(curSum, 0)
        
        return res;

"""
Line 10:
If we have diff in the prefixSums dicitonary, it means we have a subarray 
whose sum = k. If we don't find the value in the dict, we add diff as a 
key with the value 0

Line 11:
Update the frequency of the current total sum in the dictionary

nums = [2,-1,1,2], k = 2

n = 2
diff = 2 - 2 = 0
curSum = 2
prefixSums = { 0 : 1 }
res = 0 + 1 = 1
prefixSums = { 0 : 1, 2 : 1 }

n = -1
diff = 1 - 2 = -1
curSum = 1
prefixSums = { 0 : 1, 2 : 1, -1 : 0 }
res = 1 + 0 = 1
prefixSums = { 0 : 1, 2 : 1, -1 : 0, 1 : 1 }

"""