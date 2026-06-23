public class Solution {
    class ListNode
    {
        int val;
        ListNode next;

        public ListNode(int _val)
        {
            val = _val;
            next = null;
        }
    }

    public int FindDuplicate(int[] nums) {
        // // Solution using O(n) extra space
        // HashSet<int> numSet = new HashSet<int>();

        // for (int i = 0; i < nums.Length; i++) {
        //     if (numSet.Contains(nums[i]))
        //         return nums[i];
        //     numSet.Add(nums[i]);
        // }

        // return 0;

        int slow = 0, fast = 0;

        while (true) {
            slow = nums[slow];
            fast = nums[nums[fast]];
            if (slow == fast) {
                break;
            }
        }

        int slow2 = 0;

        while (true) {
            slow = nums[slow];
            slow2 = nums[slow2];

            if (slow == slow2)
                return slow;
        }
    }
}
