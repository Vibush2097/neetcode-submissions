public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        double[][] pairs = new double[n][];

        for (int i = 0; i < n; i++) {
            pairs[i] = new double[] {position[i], speed[i]};
        }

        Array.Sort(pairs, (a, b) => b[0].CompareTo(a[0]));

        double[] timeToReach = new double[n];
        int fleetCount = 0;

        for (int i = 0; i < n; i++) {
            timeToReach[i] = (target - pairs[i][0]) / pairs[i][1];

            if (i >= 1 && timeToReach[i] <= timeToReach[i-1]) {
                timeToReach[i] = timeToReach[i-1];
            }
            else
                fleetCount++;
        }

        return fleetCount;
    }
}
