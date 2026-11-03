public class Solution {
    public long MinimumHealth(int[] damage, int armor) {
        long totalHealthNeeded = 0;
        long highestDamage = 0;

        foreach (int d in damage) {
            totalHealthNeeded += d;

            highestDamage = Math.Max(d, highestDamage);
        }

        if (highestDamage <= armor) {
            totalHealthNeeded = totalHealthNeeded - highestDamage + 1;
        }
        else {
            totalHealthNeeded = totalHealthNeeded - armor + 1;
        }

        return totalHealthNeeded;
    }
}


