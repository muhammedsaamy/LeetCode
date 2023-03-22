/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null || head.next == null) return null;
            Dictionary<ListNode, int> cycle = new Dictionary<ListNode, int>();
            while (head.next != null)
            {
                if (!cycle.ContainsKey(head)) cycle[head] = 0;
                else  return head;
                head = head.next;
            }
            return null;
    }
}