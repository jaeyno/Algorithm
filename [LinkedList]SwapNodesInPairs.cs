public class LinkedList {
    public int value;
    public LinkedList next = null;

    public LinkedList(int value) {
        this.value = value;
    }

    //Simple Way to solve
    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList SwapTwoNodesInSimpleWay(LinkedList head) {
        LinkedList dummyNode = new LinkedList(-1);
        dummyNode.next = head;
        LinkedList prevNode = dummyNode;

        while (head != null && head.next != null) {
            //create two nodes to be swapped
            LinkedList firstNode = head;
            LinkedList secondNode = head.next;

            //swap the two nodes;
            prevNode.next = secondNode;
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;

            //rearrange the pointers for next iteration
            prevNode = firstNode;
            head = firstNode.next;
        }

        return dummyNode.next;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList SwapTwoNodesInHardWay(LinkedList head) {
        LinkedList newHead = null;
        LinkedList newTail = null;
        LinkedList currentNode = head;

        while (currentNode != null) {
            int count = 0;
            currentNode = head;
            while (count < 2 && currentNode != null) {
                currentNode = currentNode.next;
                count++;
            }

            if (count == 2) {
                LinkedList revHead = this.ReverseLinkedList(head);

                if (newHead == null) {
                    newHead = revHead;
                }

                if (newTail != null) {
                    newTail.next = revHead;
                }

                //rearrange the pointers for next iteration
                newTail = head;
                head = currentNode;
            }
        }

        if (newTail != null) {
            newTail.next = head;
        }

        return newHead != null ? newHead : head;
    }

    public LinkedList ReverseLinkedList(LinkedList head) {
        LinkedList prevNode = null;
        LinkedList currentNode = head;

        int count = 2;
        while (count > 0) {
            //store the reference of linkedlist;
            LinkedList nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
            count--;
        }

        return prevNode;
    }
}