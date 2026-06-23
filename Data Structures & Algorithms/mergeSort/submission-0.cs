// Definition for a pair.
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
    public List<Pair> MergeSort(List<Pair> pairs) {
        return MergeSortMain(pairs, 0, pairs.Count - 1);
    }

    public List<Pair> MergeSortMain(List<Pair> pairs, int l, int r) {
        if (l < r) {
            int m = (l + r) / 2;
            MergeSortMain(pairs, l, m);
            MergeSortMain(pairs, m + 1, r);
            Merge(pairs, l, m, r);
        }
        return pairs;
    }

    public List<Pair> Merge(List<Pair> pairs, int l, int m, int r) {
        List<Pair> tempLeft = new List<Pair>(pairs.GetRange(l, m - l + 1));
        List<Pair> tempRight = new List<Pair>(pairs.GetRange(m + 1, r - m));

        int i = 0;
        int j = 0;
        int k = l;

        while (i < tempLeft.Count && j < tempRight.Count) {
            if (tempLeft[i].Key <= tempRight[j].Key) {
                pairs[k] = tempLeft[i];
                i++;
            }
            else {
                pairs[k] = tempRight[j];
                j++;
            }
            k++;
        }

        while (i < tempLeft.Count) {
            pairs[k] = tempLeft[i];
            i++;
            k++;
        }

        while (j < tempRight.Count) {
            pairs[k] = tempRight[j];
            j++;
            k++;
        }

        return pairs;
    }
}
