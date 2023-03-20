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
    public ListNode MiddleNode(ListNode head) {
        var len = 0;
        var nodeHead = head;
        while(head != null){
            len++;
            head = head.next;
        }
        
        var index = 0;
        while(len/2 != index){
            nodeHead = nodeHead.next;
            index++;
        }
        
        return nodeHead;
    }
}