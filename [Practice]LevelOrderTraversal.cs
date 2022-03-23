public class Program {
    public class BT {
        int value;
        BT left;
        BT right;
        public BT(int value) {
            this.value = value;
        }
    }

    public List<List<int>> levels = new List<List<int>>();
    public List<List<int>> LevelOrderTraversal(BT tree) {
        if (tree == null) return levels;
        LevelOrderTraversal(tree, 0);
        return levels;
    }
    
    //pre order traversal (node - left - right)
    public void LevelOrderTraversal(BT tree, int currentLevel) {
        if (levels.Count == currentLevel) {
            levels.Add(new List<int>());
        }

        levels[currentLevel].Add(tree.value);

        if (tree.left != null) {
            LevelOrderTraversal(tree.left, currentLevel + 1);
        }

        if (tree.right != null) {
            LevelOrderTraversal(tree.right, currentLevel + 1);
        }
    }
}