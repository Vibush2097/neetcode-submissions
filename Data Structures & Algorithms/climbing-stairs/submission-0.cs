public class Solution {
    public int ClimbStairs(int n) {     
        int first = 0;
        int second = 1;

        for (int i = 0; i < n; i++) {
            int temp = second;
            second += first;
            first = temp;
        }

        return second;
    }
}
