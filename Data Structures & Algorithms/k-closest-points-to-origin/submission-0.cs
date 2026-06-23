public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int, double> pq = new PriorityQueue<int, double>();
        for (int i = 0; i < points.Length; i++) {
            int xi = points[i][0];
            int yi = points[i][1];
            double distance = Math.Sqrt(Math.Pow(xi,2) + Math.Pow(yi,2));

            pq.Enqueue(i, -distance);

            if (pq.Count > k) {
                pq.Dequeue();
            }
        }

        int[][] res = new int[k][];

        int j = 0;
        while (pq.Count > 0) {
            var index = pq.Dequeue();
            res[j++] = new int[2] { points[index][0], points[index][1] };
        }

        return res;
    }
}
