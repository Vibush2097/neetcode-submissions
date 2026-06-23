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
    // Solution with O(n) extra space
    // public void ReorderList(ListNode head) {
    //     List<ListNode> nodes = new List<ListNode>();
    //     ListNode cur = head;

    //     while (cur != null) {
    //         nodes.Add(cur);
    //         cur = cur.next;
    //     }

    //     cur = head;

    //     for (int i = 1; i < nodes.Count; i++) {
    //         int pos = i % 2 == 0 ? i / 2 : nodes.Count - 1 - (i / 2);
    //         cur.next = nodes[pos];
    //         cur = cur.next;
    //     }
    //     cur.next = null;
    // }

    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;
        ListNode prev = null;
        slow.next = null;
        while (second != null) {
            ListNode temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        ListNode first = head;
        second = prev;
        while (second != null) {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
    }
}
