public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a,b) => {
            int comp = a[0].CompareTo(b[0]);
            return comp != 0 ? comp : a[1].CompareTo(b[1]);
        });

        List<List<int>> result = new List<List<int>>();
        result.Add(intervals[0].ToList());

        for (int i = 1; i < intervals.Length; i++) {
            var prev = result[^1];
            var cur = intervals[i];

            if (prev[1] >= cur[0]) {
                result[^1][1] = Math.Max(cur[1], prev[1]);
            }
            else {
                result.Add(cur.ToList());
            }
        }

        return result.Select(x => x.ToArray()).ToArray();
    }
}
