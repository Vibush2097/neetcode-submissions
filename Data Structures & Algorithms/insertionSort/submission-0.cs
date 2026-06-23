// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        List<List<Pair>> states = new List<List<Pair>>();

        for (int i = 0; i < pairs.Count; i++) {
            int j = i - 1;
            while (j >= 0 && pairs[j + 1].Key < pairs[j].Key) {
                var temp = pairs[j + 1];
                pairs[j + 1] = pairs[j];
                pairs[j] = temp;
                j--;
            }
            
            var curState = new List<Pair>();
            for (int k = 0; k < pairs.Count; k++) {
                curState.Add(pairs[k]);
            }
            states.Add(curState);
        }

        return states;
    }
}
