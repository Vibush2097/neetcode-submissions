public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int maxL = height[0];
        int maxR = height[n - 1];
        int water = 0;
        int l = 0, r = n - 1;

        while (l < r) {
            if (maxL < maxR) {
                l++;
                maxL = Math.Max(maxL, height[l]);
                water += maxL - height[l];
            }
            else {
                r--;
                maxR = Math.Max(maxR, height[r]);
                water += maxR - height[r];
            }
        }

        return water;
    }
}
