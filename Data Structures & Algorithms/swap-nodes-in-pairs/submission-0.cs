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
    public ListNode SwapPairs(ListNode head) {
        ListNode node1, node2, temp;
        ListNode cur = head;
        ListNode prev = null;
        ListNode newHead = head;

        while (cur != null && cur.next != null) {
            node1 = cur;
            node2 = cur.next;

            node1.next = node2.next;
            node2.next = node1;
            cur = node1.next;

            if (prev == null) {
                newHead = node2;
            } else {
                prev.next = node2;
            }
            prev = node1;
        }

        return newHead;
    }
}
