public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int l = 0, r = people.Length - 1;
        int numBoats = 0;

        while (l <= r) {
            int cap = people[r];

            if (people[l] + cap <= limit && l < r) {
                cap += people[l];
                l++;
            }

            numBoats++;
            r--;
        }

        return numBoats;
    }
}