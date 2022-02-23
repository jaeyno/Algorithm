public class Program {
    public class LinkedList {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value) {
            this.value = value;
        }
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ReverseLinkedList(LinkedList head) {
        LinkedList prevNode = null;
        LinkedList currentNode = head;
        
        while (currentNode != null) {
            LinkedList nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
        }
        
        return prevNode;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ReverseLinkedListByK(LinkedList head, int k) {
        LinkedList prevNode = null;
        LinkedList currentNode = head;
        
        while (k > 0) {
            LinkedList nextNode = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = nextNode;
            k--;
        }
        
        return prevNode;
    }

    //Time Complexity: O(n) | Space Complexity: O(1)
    public LinkedList ReverseLinkedListbyKGroup(LinkedList head, int k) {
        LinkedList newHead = null;
        LinkedList newTail = null;
        LinkedList currentNode = head;

        while (currentNode != null) {
            int count = 0;
            while (count < k && currentNode != null) {
                currentNode = currentNode.next;
                count++;
            }
            
            if (count == k) {
                LinkedList revHead = this.ReverseLinkedListByK(head, k);

                //For first iteration
                if (newHead == null) {
                    newHead = revHead;
                }

                //For next iterations
                if (newTail != null) {
                    newTail.next =revHead;
                }

                //arrange the pointers for next iteration
                newTail = head;
                head = currentNode;
            }
        }

        //attach the remaining
        if (newTail != null) {
            newTail.next = head;
        }

        return newHead == null ? head : newHead;
    }
}