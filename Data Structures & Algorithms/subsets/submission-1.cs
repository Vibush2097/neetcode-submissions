// Iterative Solution
public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        result.Add(new List<int>());

        foreach (int num in nums) {
            int size = result.Count;
            for (int i = 0; i < size; i++) {
                List<int> subset = new List<int>(result[i]);
                subset.Add(num);
                result.Add(subset);
            }
        }

        return result;
    }
}
