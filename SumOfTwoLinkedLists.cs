using System.Collections.Generic;
using System;


public class Program {
	// This is an input class. Do not edit.
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

	//O(max(n, m)) time | O(max(n, m)) space where n is the length of the first linked list & m is the length of the second linked list
	public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo) {
		LinkedList newLinkedListHeadPointer = new LinkedList(0);
		LinkedList currentNode = newLinkedListHeadPointer;
		int carry = 0;
		
		LinkedList nodeOne = linkedListOne;
		LinkedList nodeTwo = linkedListTwo;
		
		while (nodeOne != null || nodeTwo != null || carry != 0) {
			int valueOne = (nodeOne != null) ? nodeOne.value : 0;
			int valueTwo = (nodeTwo != null) ? nodeTwo.value : 0;
			int sumOfValues = valueOne + valueTwo + carry;
			
			int newValue = sumOfValues % 10;
			LinkedList newNode = new LinkedList(newValue);
			currentNode.next = newNode;
			currentNode = newNode;
			
			carry = sumOfValues / 10;
			nodeOne = (nodeOne != null) ? nodeOne.next : null;
			nodeTwo = (nodeTwo != null) ? nodeTwo.next : null;
		}
		
		return newLinkedListHeadPointer.next;
	}
}

