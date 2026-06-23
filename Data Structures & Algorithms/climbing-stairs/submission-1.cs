// public class Solution {
//     public int ClimbStairs(int n) {     
//         int first = 0;
//         int second = 1;

//         for (int i = 0; i < n; i++) {
//             int temp = second;
//             second += first;
//             first = temp;
//         }

//         return second;
//     }
// }

// Top Down DP
public class Solution {
    int[] cache;
    public int ClimbStairs(int n) {     
        cache = new int[n];

        for (int i = 0; i < n; i++) {
            cache[i] = -1;
        }

        return Dfs(n, 0);
    }

    private int Dfs(int n, int i) {
        if (i >= n) {
            return i == n ? 1 : 0;
        }

        if (cache[i] != -1) {
            return cache[i];
        }

        cache[i] = Dfs(n, i + 1) + Dfs(n, i + 2);
        return cache[i];
    }
}