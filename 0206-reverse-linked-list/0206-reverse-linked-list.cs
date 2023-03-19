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
public class Solution
{
    private ListNode _reversedHead;

    public ListNode ReverseList(ListNode head)
    {
        if (head == null) return head;
        var last = RecursionReverse(head);
        last.next = null;

        return _reversedHead;
    }

    public ListNode RecursionReverse(ListNode node)
    {
        if (node.next == null)
        {
            _reversedHead = node;
            return node;
        }
        var next = RecursionReverse(node.next);
        next.next = node;
        return node;

    }
}