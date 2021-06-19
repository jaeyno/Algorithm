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
public class Solution {
  public ListNode sortList(ListNode head) {
    //To sort the linked list first, I will use the merge sort
    //To use the merge sort, we need to get the middle point of the list
    ListNode middlePointer = null;
    ListNode slowPointer = head; //move next by 1
    ListNode fastPointer = head; //move next by 2 

    // 1 - 2 - 3 - 4 - 5 - 6 - 7
    // s - s - s - s
    // f-------f-------f--------f
    while (slowPointer != null && fastPointer != null) {
        middlePointer = slowPointer;
        slowPointer = slowPointer.next;
        fastPointer = fastPointer.next.next;
    }

    middlePointer.next = null; // 4 - 5 - 6 - 7 => 4 - null

    we can sort each half recursively
    ListNode firstHalfList = sortList(head);
    ListNode secondHalfList = sortList(slowPointer);

    return merge(firstHalfList, secondHalfList);
  }

  ListNode merge(ListNode firstHalfList, ListNode secondHalfList) {
      ListNode dummyNode = new ListNode(-1);
      ListNode pointer = dummyNode;

      while(firstHalfList != null && secondHalfList !=null) {
          if (firstHalfList.val < secondHalfList.val) {
              pointer.next = firstHalfList; // -1 - 1
              firstHalfList = firstHalfList.next; // 1 
          } else {
              pointer.next = secondHalfList;
              secondHalfList = secondHalfList.next;
          }
          pointer = pointer.next;
      }

      if (firstHalfList != null) {
          pointer.next = firstHalfList;
      }

      if (secondHalfList != null) {
          pointer.next = secondHalfList;
      }

      return dummyNode.next;

      //time complexity: O(nlog(n)) | space complexity: O(n)
  }
}