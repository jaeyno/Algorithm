public class LinkedList {
    public int value;
    public LinkedList next = null;
    public LinkedList(int value) {
        this.value = value;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ShiftLinkedList(LinkedList head, int k) {
        //find the tail node and length of this given linked list
        LinkedList tail = head;
        int length = 1;
        while (tail.next != null) {
            tail = tail.next;
            length++;
        }

        //find the offset
        int offset = Math.Abs(k) % length;
        if (offset == 0) {
            return head;
        }
        int newTailPosition = k > 0 ? length - offset : offset;

        //find the new tail
        LinkedList newTail = head;
        for (int i = 1; i < newTailPosition; i++) {
            newTail = newTail.next;
        }

        //find the new head;
        LinkedList newHead = newTail.next;

        newTail.next = null;
        tail.next = head;
        return newHead;
    }
}