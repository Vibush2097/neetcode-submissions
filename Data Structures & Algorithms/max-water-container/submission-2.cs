public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        int maxWater = Math.Min(heights[l], heights[r]) * (r - l);

        while (l < r) {
            if (heights[l] < heights[r]) {
                l++;
            }
            else {
                r--;
            }

            maxWater = Math.Max(maxWater, Math.Min(heights[l], heights[r]) * (r - l));
        }

        return maxWater;
    }
}

