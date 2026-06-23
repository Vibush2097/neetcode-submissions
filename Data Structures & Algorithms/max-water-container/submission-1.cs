public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length - 1;
        int water = 0, maxWater = 0;

        while (l < r) {
            water = Math.Min(heights[l], heights[r]) * (r - l);
            maxWater = Math.Max(water, maxWater);

            if (heights[l] <= heights[r]) {
                l++;
            }
            else {
                r--;
            }
        }

        return maxWater;
    }
}
