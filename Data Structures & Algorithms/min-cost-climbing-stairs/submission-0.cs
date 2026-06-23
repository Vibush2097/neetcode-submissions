public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        return Math.Min(Dfs(cost, 0, 0), Dfs(cost, 1, 0));
    }

    private int Dfs(int[] cost, int i, int curCost) {
        if (i >= cost.Length) {
            return curCost;
        }

        curCost = cost[i] + Math.Min(Dfs(cost, i + 1, curCost), Dfs(cost, i + 2, curCost));
        return curCost;
    }
}
