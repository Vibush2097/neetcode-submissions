public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // // Solution with O(n) extra space and O(nlogn) time complexity
        // Dictionary<int, int> dict = new Dictionary<int, int>();

        // foreach (int n in nums) {
        //     if (!dict.ContainsKey(n))
        //         dict[n] = 0;
        //     dict[n]++;
        // }

        // int[] result = new int[k];
        // int count = dict.Count;

        // foreach (KeyValuePair<int, int> kvp in dict.OrderBy(item => item.Value)) {

        //     if (count <= k) {
        //         result[k-count] = kvp.Key;
        //     }
        //     count--;
        // }

        // return result;

        // My implementation for the bucket sort approach

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach(int n in nums) {
            if (!count.ContainsKey(n))
                count[n] = 0;
            count[n]++;
        }

        List<int>[] freq = new List<int>[nums.Length+1];

        for (int i=0; i<=nums.Length; i++) {
            freq[i] = new List<int>();
        }


        foreach (var kvp in count) {
            freq[kvp.Value].Add(kvp.Key);
        }

        int[] result = new int[k];
        int index=0;
        for (int i = freq.Length-1; i>0 && index<k; i--) {
            foreach (int n in freq[i]) {
                result[index++] = n;
                if (index == k)
                    return result;
            }
        }

        return result;
    }
}
