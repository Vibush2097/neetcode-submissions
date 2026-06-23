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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int len = 0;
        ListNode cur = head;

        while (cur != null) {
            len++;
            cur = cur.next;
        }

        if (len == 1) {
            return null;
        }

        int pos = len - n + 1;

        if (pos == 1) {
            head = head.next;
            return head;
        }
        
        ListNode prev = head;
        cur = head;

        for (int i = 1; i < pos; i++) {
            prev = cur;
            cur = cur.next;
        }
        prev.next = cur.next;
        return head;
    }
}
