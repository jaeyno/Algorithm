public class Solution {
    //Time Complexity: O(kN) - k is the number of linked lists | Space Complexity: O(1)
    public LinkedList MergeKLinkedLists(LinkedList[] heads) {
        LinkedList head = null;
        for (int i = 0; i < heads.Length; i++) {
            head = this.MergeTwoLinkedLists(head, heads[i]);
        }
        return head;
    }

    private LinkedList MergeTwoLinkedLists(LinkedList head1, LinkedList head2) {
        LinkedList dummyNode = new LinkedList(-1);
        LinkedList newHead = dummyNode;

        while (head1 != null && head2 != null) {
            if (head1.value <= head2.value) {
                newHead.next = head1;
                head1 = head1.next;
            } else {
                newHead.next = head2;
                head2 = head2.next;
            }

            newHead = newHead.next;
        }

        newHead.next = head1 == null ? head2 : head1;

        return dummyNode.next;
    }
}