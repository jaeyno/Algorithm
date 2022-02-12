using System;

public class Program {
	public int BinaryTreeDiameter(BinaryTree tree) {
		return getTreeInfo(tree).diameter;
	}
	
    //Time Complexity: O(n) | Space Complexity: O(h) - h is height of binary tree
	public TreeInfo getTreeInfo(BinaryTree tree) {
		if (tree == null) {
			return new TreeInfo(0, 0);
		}
		
		TreeInfo leftInfo = getTreeInfo(tree.left);
		TreeInfo rightInfo = getTreeInfo(tree.right);
		
		int longestPath = leftInfo.height + rightInfo.height;
		int maxDiameter = Math.Max(leftInfo.diameter, rightInfo.diameter);
		int currentDiameter = Math.Max(longestPath, maxDiameter);
		int currentHeight = 1 + Math.Max(leftInfo.height, rightInfo.height);
		
		return new TreeInfo(currentDiameter, currentHeight);
		
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
		}
	}
	
	public class TreeInfo {
		public int diameter;
		public int height;
		public TreeInfo(int diameter, int height) {
			this.diameter = diameter;
			this.height = height;
		}
	}
}

