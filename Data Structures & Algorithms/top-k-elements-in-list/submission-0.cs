public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int n in nums) {
            if (!dict.ContainsKey(n))
                dict[n] = 0;
            dict[n]++;
        }

        int[] result = new int[k];
        int count = dict.Count;

        foreach (KeyValuePair<int, int> kvp in dict.OrderBy(item => item.Value)) {

            if (count <= k) {
                result[k-count] = kvp.Key;
            }
            count--;
        }

        return result;
    }
}
