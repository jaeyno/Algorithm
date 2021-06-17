/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {

    //function that reverse the linked list
    public ListNode reverseLinkedList(ListNode head, int k) {
        ListNode pointer = head;
        ListNode newHead = null;

        while (k > 0) {
            //move to next node
            ListNode nextNode = pointer.next;

            //reverse the linked list 
            pointer.next = newHead;
            newHead = pointer;

            //move the pointer to next node
            pointer = nextNode;

            k--;
        }

        return newHead;
    }

    public ListNode reverseKGroup(ListNode head, int k) {
        ListNode pointer = head;
        ListNode newHead = null;

        //ktail should be the head of the previous set of k nodes before its reversal.
        // 1 - 2 - 3 -4 => 2 - 1 - 3 - 4 by keeping the ktail as 1, we can connect 1 to the newly resversed list, which is 4 - 3
        ListNode ktail = null;

        //we traverse all the nodes
        while (pointer != null) {

            //move the pointer upto k nodes
            int count = 0;
            while (count < k && pointer != null) {
                pointer = pointer.next;
                count++;
            }

            if (count == k) {
                ListNode revHead = this.reverseLinkedList(head, k);

                if (newHead == null) {
                    newHead = revHead;
                }

                if (ktail != null) {
                    ktail.next = revHead;
                }
                
                // 2 - 1 - 3 - 4 - 5
                ktail = head; //1 3
                head = pointer; //3 5
            }
        }

        //add the remaining node to the ktail. 2 - 1 - 4 - 3 - 5'
        if (ktail != null) {
            ktail.next = head;
        }

        return newHead != null ? newHead : head;

        //Time Complexity: O(n) | Space Complexity: O(1)
    }
}