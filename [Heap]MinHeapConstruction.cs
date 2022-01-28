using System;
using System.Collections.Generic;

// Do not edit the class below except for the buildHeap,
// siftDown, siftUp, Peek, Remove, and Insert methods.
// Feel free to add new properties and methods to the class.
public class Program {
	public class MinHeap {
		public List<int> heap = new List<int>();

		public MinHeap(List<int> array) {
			heap = buildHeap(array);
		}

		public List<int> buildHeap(List<int> array) {
			// Write your code here.
			int firstParentIndex = (array.Count - 2) / 2;
			for (int currentIndex = firstParentIndex; currentIndex >= 0; currentIndex--) {
				siftDown(currentIndex, array.Count - 1, array);
			}
			return array;
		}

		public void siftDown(int currentIndex, int endIndex, List<int> heap) {
			//figure out the firstChild
			int firstChildIndex = (currentIndex * 2) + 1;
			//Iterate untill first child index reaches the end index
			while (firstChildIndex <= endIndex) {
				int secondChildIndex = (currentIndex * 2) + 2 <= endIndex ? (currentIndex * 2) + 2 : -1;
				int indexToSwap;
				if (secondChildIndex != -1 && heap[secondChildIndex] < heap[firstChildIndex]) {
					indexToSwap = secondChildIndex;
				} else {
					indexToSwap = firstChildIndex;
				}
				if (heap[indexToSwap] < heap[currentIndex]) {
					Swap(currentIndex, indexToSwap, heap);
					currentIndex = indexToSwap;
					firstChildIndex = (currentIndex * 2) + 1;
				} else {
					return;
				}
			}
		}

		public void siftUp(int currentIndex, List<int> heap) {
			// Write your code here.
			int parentIndex = (currentIndex - 1) / 2;
			while (currentIndex > 0 && heap[currentIndex] < heap[parentIndex]) {
				Swap(currentIndex, parentIndex, heap);
				currentIndex = parentIndex;
				parentIndex = (currentIndex - 1) /2;
			}
		}

		public int Peek() {
			// Write your code here.
			return heap[0];
		}

		public int Remove() {
			// Write your code here.
			Swap(0, heap.Count - 1, heap);
			int valueToRemove = heap[heap.Count - 1];
			heap.RemoveAt(heap.Count - 1);
			siftDown(0, heap.Count - 1, heap);
			return valueToRemove;
		}

		public void Insert(int value) {
			// Write your code here.
			heap.Add(value);
			siftUp(heap.Count - 1, heap);
		}
		
		public void Swap(int i, int j, List<int> heap) {
			int temp = heap[j];
			heap[j] = heap[i];
			heap[i] = temp;
		}
	}
}
