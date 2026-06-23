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
        int carry = 0, sum = 0;
        ListNode result = new ListNode(0);
        ListNode temp = result;

        while (l1 != null || l2 != null || carry != 0) {
            int v1 = l1 != null ? l1.val : 0;
            int v2 = l2 != null ? l2.val : 0;
            sum = carry + v1 + v2;
            ListNode curr = new ListNode(sum % 10);
            carry = sum / 10;
            temp.next = curr;
            temp = curr;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
        }

        while (l1 != null) {
            ListNode curr = new ListNode(l1.val);
            temp.next = curr;
            temp = curr;
        }

        while (l2 != null) {
            ListNode curr = new ListNode(l2.val);
            temp.next = curr;
            temp = curr;
        }

        temp.next = null;

        return result.next;
    }
}
