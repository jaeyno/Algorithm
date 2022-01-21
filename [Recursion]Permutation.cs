using System;
using System.Collections.Generic;

public class Program {
	public static List<List<int> > GetPermutations(List<int> array) {
		// create a empty array to store permutations
		List<List<int>> permutations = new List<List<int>>();
		GetPermutationsHelper(0, array, permutations);
		return permutations;
	}
	
	public static void GetPermutationsHelper(int i, List<int> array, List<List<int>> permutations) {
		// end condition if the index is end of array
		if (i == array.Count - 1) {
			permutations.Add(new List<int>(array));
		} else {
			for (int j = i; j < array.Count; j++) {
				Swap(array, i, j);
				GetPermutationsHelper(i + 1, array, permutations);
				Swap(array, i, j);
			}
		}
	}
	
	public static void Swap(List<int> array, int i, int j) {
		int tmp = array[i];
		array[i] = array[j];
		array[j] = tmp;
	}
    //Time Complexity: O(n*n!) | Space Complexity: O(n*n!)
}
