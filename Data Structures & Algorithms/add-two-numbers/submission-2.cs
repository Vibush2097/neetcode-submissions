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
    // public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
    //     ListNode sumList = new ListNode(-1);
    //     ListNode temp = sumList;

    //     int carry = 0, sum = 0;
    //     while (l1 != null || l2 != null) {
    //         sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0); 
    //         carry = sum / 10;
    //         ListNode cur = new ListNode(sum % 10);
    //         sumList.next = cur;
    //         sumList = sumList.next;
    //         l1 = l1 != null ? l1.next : null;
    //         l2 = l2 != null ? l2.next : null;
    //     }

    //     if (carry != 0) {
    //         ListNode cur = new ListNode(carry);
    //         sumList.next = cur;
    //         sumList = sumList.next;
    //         carry = 0;
    //     }

    //     return temp.next;
    // }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode cur = l1;
        ListNode temp;
        int m = 0, n = 0;

        while (cur != null) {
            m++;
            cur = cur.next;
        }

        cur = l2;
        while (cur != null) {
            n++;
            cur = cur.next;
        }

        int sum = 0, carry = 0;
        if (m > n) {
            temp = l1;
            while (l1 != null || l2 != null) {
                sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0); 
                carry = sum / 10;
                l1.val = sum % 10;
                cur = l1;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
        }
        else {
            temp = l2;
            while (l1 != null || l2 != null) {
                sum = carry + (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0); 
                carry = sum / 10;
                l2.val = sum % 10;
                cur = l2;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
        }

        if (carry != 0) {
            cur.next = new ListNode(1);
        }

        return temp;
    }
}
