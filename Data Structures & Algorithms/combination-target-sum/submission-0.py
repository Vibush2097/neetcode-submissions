from collections import defaultdict

class Solution:
    def combinationSum(self, nums: List[int], target: int) -> List[List[int]]:
        results = []

        # def combinations(i, cur, total):
        #     if total == target:
        #         results.append(list(cur))
        #         return

        #     if i>= len(nums) or total > target:
        #         return

        #     cur.append(nums[i])
        #     combinations(i, cur, total + nums[i])
        #     cur.pop()
        #     combinations(i + 1, cur, total)

        # combinations(0, [], 0)
        # return results

        def combinations(i, comb, total):
            if total == 0:
                results.append(list(comb))
                return

            if i >= len(nums) or total < 0:
                return

            comb.append(nums[i])
            combinations(i, comb, total - nums[i])
            comb.pop()
            combinations(i + 1, comb, total)

        combinations(0, [], target)
        return results