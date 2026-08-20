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
    // Time Complexity: O(n)
    // Space Complexity: O(n)
    // public ListNode RemoveNthFromEnd(ListNode head, int n) {
    //     List<ListNode> nodes = new List<ListNode>();
    //     ListNode temp = head;

    //     while (temp != null) {
    //         nodes.Add(temp);
    //         temp = temp.next;
    //     }

    //     int count = nodes.Count;
    //     int pos = count - n;
    //     int prevPos = pos - 1;

    //     if (prevPos < 0) {
    //         head = head.next;
    //         return head;
    //     }

    //     nodes[prevPos].next = nodes[pos].next;
    //     return head;
    // }

    // Time Complexity: O(n)
    // Space Complexity: O(n)
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 0;
        ListNode temp = head;

        while (temp != null) {
            count++;
            temp = temp.next;
        }

        int pos = count - n - 1;
        temp = head;

        if (pos < 0) {
            head = head.next;
            return head;
        }

        while (pos > 0) {
            temp = temp.next;
            pos--;
        }
        temp.next = temp.next.next;
        return head;
    }
}
