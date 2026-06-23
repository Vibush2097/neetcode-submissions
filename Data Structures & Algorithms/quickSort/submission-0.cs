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
    public List<Pair> QuickSort(List<Pair> pairs) {
        QuickSorting(pairs, 0, pairs.Count - 1);
        return pairs;
    }

    // s = start, e = end
    public void QuickSorting(List<Pair> arr, int s, int e) {
        // If you have an array of 1 element, its already sorted
        if (e - s + 1 <= 1) {
            return;
        }

        // Choosing the last element as the pivot
        var pivot = arr[e];
        int left = s;

        for (int i = s; i < e; i++) {
            if (arr[i].Key < pivot.Key) {
                var temp = arr[i];
                arr[i] = arr[left];
                arr[left] = temp;
                left++;
            }
        }

        arr[e] = arr[left];
        arr[left] = pivot;

        QuickSorting(arr, s, left - 1);
        QuickSorting(arr, left + 1, e);
    }
}
