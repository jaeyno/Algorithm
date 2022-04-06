public class Solution {
    public LinkedList MergeTwoLinkedLists(LinkedList head1, LinkedList head2) {
        //Initialize variables
        LinkedList DummyNode = new LinkedList(-1);
        LinkedList newHead = DummyNode;

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

        newHead.next = head1 == null ? head1 : head2;
        
        return dummyNode.next;
    }
}