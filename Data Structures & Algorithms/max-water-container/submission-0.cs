public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0, r = heights.Length-1;

        int max = 0;

        // for (int i=0; i<heights.Length; i++) {
        //     for (int j=i+1; j<heights.Length; j++) {
        //         int height = Math.Min(heights[i], heights[j]) * (j-i);
        //         max = Math.Max(height, max);
        //     }
        // }

        int height = 0;
        while (l < r) {
            height = Math.Min(heights[l], heights[r]) * (r-l);
            max = Math.Max(height, max);

            if (heights[l] < heights[r])
                l++;
            else if (heights[r] < heights[l])
                r--;
            else {
                r--;
                l++;
            }
        }

        return max;
    }
}
