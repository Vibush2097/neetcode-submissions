public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();
        int m;
        double time;

        while (l < r) {
            m = (l + r) / 2;
            time = Math.Ceiling(TimeToEat(piles, m));

            if (time <= h) {
                r = m;
            }
            else {
                l = m + 1;
            }
        }

        return l;
    }

    private double TimeToEat(int[] piles, int k) {
        double hours = 0.0;

        foreach (var pile in piles) {
            hours += Math.Ceiling((double) pile / (double) k);
        }

        return hours;
    }
}

// [25,10,23,4]
// l = 4, r = 25
// m = 14, time = 6

// l = 15, r = 25
// m = 20, time = 6

// l = 21, r = 25
// m = 23, time = 5

// l = 24, r = 25
// m = 24, time = 5

// l = 25, r = 25
// m = 24, time = 5