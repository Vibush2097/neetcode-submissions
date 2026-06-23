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
        ListNode sumList = new ListNode(-1);
        ListNode temp = sumList;

        int carry = 0, sum = 0;
        while (l1 != null || l2 != null) {
            sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0); 
            carry = sum / 10;
            ListNode cur = new ListNode(sum % 10);
            sumList.next = cur;
            sumList = sumList.next;
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
            // if (l1 != null && l2 != null) {
            //     sum = carry + l1.val + l2.val; 
            //     carry = sum / 10;
            //     ListNode cur = new ListNode(sum % 10);
            //     sumList.next = cur;
            //     sumList = sumList.next;
            //     l1 = l1.next;
            //     l2 = l2.next;
            // }
            // else if (l1 != null) {
            //     sum = carry + l1.val; 
            //     carry = sum / 10;
            //     ListNode cur = new ListNode(sum % 10);
            //     sumList.next = cur;
            //     sumList = sumList.next;
            //     l1 = l1.next;
            // }
            // else {
            //     sum = carry + l2.val; 
            //     carry = sum / 10;
            //     ListNode cur = new ListNode(sum % 10);
            //     sumList.next = cur;
            //     sumList = sumList.next;
            //     l2 = l2.next;
            // }
        }

        if (carry != 0) {
            ListNode cur = new ListNode(carry);
            sumList.next = cur;
            sumList = sumList.next;
            carry = 0;
        }

        return temp.next;
    }
}
