/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(-1);
        ListNode head1 = head;
        int val = 0, carry = 0;

        while (l1 != null || l2 != null) {
            int v1 = l1 != null ? l1.val : 0;
            int v2 = l2 != null ? l2.val : 0;
            val = v1 + v2 + carry;
            carry = val / 10;
            val = val % 10;

            ListNode temp = new ListNode(val);
            head1.next = temp;
            head1 = head1.next;

            if (l1 != null) {
                l1 = l1.next;
            }

            if (l2 != null) {
                l2 = l2.next;
            }
        }

        if (carry > 0) {
            ListNode temp = new ListNode(carry);
            head1.next = temp;
            head1 = head1.next;
        }

        return head.next;
    }
}
