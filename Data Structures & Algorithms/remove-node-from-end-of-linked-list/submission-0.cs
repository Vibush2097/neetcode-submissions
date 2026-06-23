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
        int i = 0;
        ListNode curr = head;

        while (curr != null) {
            i++;
            curr = curr.next;
        }

        int totalNodes = i;
        ListNode prev = head;
        curr = head;

        if (totalNodes == n)
        {
            head = head.next;
            return head;
        }

        for (i = 0; i < totalNodes; i++) {
            if ((totalNodes - i) == n) {
                prev.next = curr.next;
                break;
            }
            prev = curr;
            curr = curr.next;
        }

        return head;
    }
}
