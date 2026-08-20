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
        List<ListNode> nodes = new List<ListNode>();
        ListNode temp = head;

        while (temp != null) {
            nodes.Add(temp);
            temp = temp.next;
        }

        int count = nodes.Count;
        int pos = count - n;
        int prevPos = pos - 1;

        if (prevPos < 0) {
            head = head.next;
            return head;
        }

        nodes[prevPos].next = nodes[pos].next;
        return head;
    }
}
