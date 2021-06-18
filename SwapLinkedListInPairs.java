/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public ListNode swapPairs(ListNode head) {
        //I will create a dummy node to store all the linked list
        ListNode dummyNode = new ListNode(-1);
        dummyNode.next = head; // -1 - 1 - 2 - 3 - 4
        ListNode prevNode = dummyNode; //the prevNode is the head of the two swapped nodes before those two got swapped.

        while (head != null && head.next != null) {
            //I will create two nodes that need to be swapped each other
            ListNode firstNode = head; //1 - 2 - 3 - 4 => 3 - 4
            ListNode secondNode = head.next; //2 - 3 - 4 => 4 - null

            //I will swap those two nodes each other
            firstNode.next = secondNode.next; //1 - 3 - 4 => 3 - null => 3 - null
            secondNode.next = firstNode; //2 - 1 - 3 - 4 => 4 - 3 - null
            prevNode.next = secondNode;  //-1 - 2 - 1 - 3 - 4 => 1 - 4 - 3 - null

            //reinitiate the head and prevNode for the next iteration
            prevNode = firstNode; //1 - 3 - 4
            head = firstNode.next; //3 - 4 
        }

        return dummyNode.next;
        //Time Complexity: O(n) | Space Complexity: O(1)
    }
}