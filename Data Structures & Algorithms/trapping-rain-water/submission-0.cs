public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] maxLeft = new int[n];
        int[] maxRight = new int[n];
        int[] minLR = new int[n];

        int curMax = 0;
        for (int i=0; i<n; i++) {
            maxLeft[i] = curMax;
            curMax = Math.Max(height[i], curMax);
        }

        curMax = 0;
        for (int i=n-1; i>=0; i--) {
            maxRight[i] = curMax;
            curMax = Math.Max(height[i], curMax);
        }

        // water[i] = MinLR - height[i]
        for (int i=0; i<n; i++) {
            minLR[i] = Math.Min(maxLeft[i], maxRight[i]);
        }

        int totalWater = 0;
        for (int i=0; i<n; i++) {
            totalWater += height[i] >= minLR[i] ? 0 : minLR[i]-height[i];  
        }
        return totalWater;
    }
}
