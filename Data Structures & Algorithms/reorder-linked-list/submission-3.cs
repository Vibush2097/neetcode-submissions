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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode secondHalf = slow.next;
        slow.next = null;
        ListNode prev = null;

        while (secondHalf != null) {
            ListNode temp = secondHalf.next;
            secondHalf.next = prev;
            prev = secondHalf;
            secondHalf = temp;
        } 

        ListNode t = new ListNode(-1);
        ListNode front = head;
        ListNode back = prev;
        int i = 0;

        while (front != null || back != null) {
            if (back == null || (front != null && i % 2 == 0)) {
                t.next = front;
                front = front.next;
            }
            else {
                t.next = back;
                back = back.next;
            }
            t = t.next;
            i++;
        }
    }
}
