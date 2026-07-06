class Solution:
    # def twoSum(self, numbers: List[int], target: int) -> List[int]:
    #     indices = {}

    #     for i in range(len(numbers)):
    #         n = numbers[i]
    #         if n in indices:
    #             indices[n].append(i)
    #         else:
    #             indices[n] = [i]

    #     for i in range(len(numbers)):
    #         n = numbers[i]
    #         diff = target - n
    #         if diff in indices:
    #             j = 0
    #             while j < len(indices[diff]):
    #                 if i != indices[diff][j]:
    #                     return [i+1, indices[diff][j] + 1]
    #                 else:
    #                     j = j + 1
    #     return [-1, -1]
    
    # Time Complexity: O(n)
    # Space Complexity: O(n)

    def twoSum(self, numbers: List[int], target: int) -> List[int]:
        l = 0
        r = len(numbers) - 1

        while l < r:
            sumN = numbers[l] + numbers[r]

            if sumN > target:
                r = r - 1
            elif sumN < target:
                l = l + 1
            else:
                if l != r and l < r:
                    return [l+1, r+1]
                else:
                    l = l + 1

        return [-1, -1]
