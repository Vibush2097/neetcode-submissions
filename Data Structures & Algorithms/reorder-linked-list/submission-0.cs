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
        if (head == null || head.next == null)
            return;

        List<ListNode> nodeList = new List<ListNode>();
        ListNode temp = head;

        while (temp != null) {
            nodeList.Add(temp);
            temp = temp.next;
        }

        int n = nodeList.Count;
        int l = 1, r = n - 1;
        temp = head;
        
        while (l < r) {
            temp.next = nodeList[r];
            r--;
            temp = temp.next;
            temp.next = nodeList[l];
            l++;
            temp = temp.next;
        }

        if (l == r) {
            temp.next = nodeList[l];
            temp = temp.next;
        }

        temp.next = null;
    }
}
