from collections import Counter
import heapq

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        numCounts = Counter(nums)
        heap_elements = []

        for key, value in numCounts.items():
            heap_elements.append((-value, key))

        heapq.heapify(heap_elements)

        result = []
        for i in range(k):
            result.append(heapq.heappop(heap_elements)[1])
        
        return result
        