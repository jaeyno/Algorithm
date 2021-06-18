/*
// Definition for a Node.
class Node {
    public int val;
    public Node next;
    public Node random;

    public Node() {}

    public Node(int _val,Node _next,Node _random) {
        val = _val;
        next = _next;
        random = _random;
    }
};
*/
public class Solution {
  public Node copyRandomList(Node head) {
    if (head == null) {
        return null;
    }

    //I will create a cloned node for each original node
    //I will weave those two nodes like the below
    //Before weaving those nodes, orignal linked list: A - B - C => After weaving, A - A' - B - B' - C - C'
    Node pointer = head;
    while (pointer != null) {
        Node clonedNode = new Node(pointer.val); // A => A'
        clonedNode.next = pointer.next; // A' - B - C
        pointer.next = clonedNode; // A - A' - B - C 

        //need to move the pointer to the next orignal node, B
        pointer = clonedNode.next;
    }

    //After the first while loop, A - A' - B - B' - C - C' - null
    //Now, i will assign the random pointers of the cloned nodes
    //A'.random should point to C'
    //A'.random = C.next
    pointer = head;
    while (pointer != null) {
        pointer.next.random = (pointer.random == null) ? null : pointer.random.next;
        pointer = pointer.next.next;
    }

    //A - A' - B - B' - C - C'
    //we need to unweave the linked list to A - B - C && A' - B' - C'
    Node pointer_first = head; // for original list
    Node pointer_second = head.next; // for cloned list
    pointer = head.next;

    while (pointer_first != null) {
        pointer_first.next = pointer_first.next.next; //A - B
        pointer_second.next = (pointer_second.next != null) ? pointer_second.next.next : null; //A' - B'
        pointer_first = pointer_first.next; //B
        pointer_second = pointer_second.next; // B'
    }
    return pointer; //A' - B' - C'


    //Time complexity O(n) | Space complexity O(1);
  }
}