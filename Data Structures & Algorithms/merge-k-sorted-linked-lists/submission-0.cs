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
    public ListNode MergeKLists(ListNode[] lists) {
        // // Brute Force solution
        // ListNode minNode = new ListNode(1001);
        // ListNode result = new ListNode(0);
        // ListNode curr = result;
        // int index = -1;

        // while (true) {
        //     for (int i = 0; i < lists.Length; i++) {
        //         if (lists[i] != null && lists[i].val <= minNode.val) {
        //             minNode = lists[i];
        //             index = i;
        //         }
        //     }

        //     if (index == -1) {
        //         break;
        //     }

        //     curr.next = minNode;
        //     curr = curr.next;
        //     lists[index] = lists[index].next;
        //     index = -1;
        //     minNode = new ListNode(1001);
        // }

        // curr.next = null;

        // return result.next;

        if (lists.Length == 0) {
            return null;
        }

        while (lists.Length > 1) {
            ListNode[] mergedLists = new ListNode[(lists.Length + 1) / 2];

            for (int i = 0; i < lists.Length; i += 2) {
                var l1 = lists[i];
                var l2 = ((i + 1) < lists.Length) ? lists[i + 1] : null;
                mergedLists[i/2] = (MergeLists(l1, l2));
            }
            lists = mergedLists;
        }

        return lists[0];
    }

    public ListNode MergeLists(ListNode l1, ListNode l2)
    {
        ListNode sorted = new ListNode();
        ListNode current = sorted;

        while (l1 != null && l2 != null) {
            if (l1.val <= l2.val) {
                current.next = l1;
                l1 = l1.next;
            }
            else {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        if (l1 != null) {
            current.next = l1;
        }

        if (l2 != null) {
            current.next = l2;
        }

        return sorted.next;
    }
}
