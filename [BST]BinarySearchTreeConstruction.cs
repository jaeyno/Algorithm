public class Program {
    public class BST {
        public int value;
        public BST left;
        public BST right;

        public BST(int value) {
            this.value = value;
        }

        //Average Time Complexity: O(log(n)) | Space Complexity: O(log(n))
        //Worst Time Complexity: O(n) | Space Complexity: O(n) due to a single linked list
        public BST Insert(int value) {
            if (value < this.value) {
                if (left == null) {
                    BST newNode = new BST(value);
                    left = newNode;
                } else {
                    left.Insert(value);
                }
            } else {
                if (right == null) {
                    BST newNode = new BST(value);
                    right = newNode;
                } else {
                    right.Insert(value);
                }
            }
            return this;
        }

        //Average Time Complexity: O(log(n)) | Space Complexity: O(log(n))
        //Worst Time Complexity: O(n) | Space Complexity: O(n) due to a single linked list
        public bool Contains(int value) {
            // when a new value is smaller than its value
            if (value < this.value) {
                if (left == null) {
                    return false;
                } else {
                    return left.Contains(value);
                }
            // When a new value is greater than its value
            } else if (value > this.value) {
                if (right == null) {
                    return false;
                } else {
                    return right.Contains(value);
                }
            // When a new value is equal to its value
            } else {
                return true;
            }
        }

        //Average Time Complexity: O(log(n)) | Space Complexity: O(log(n))
        //Worst Time Complexity: O(n) | Space Complexity: O(n) due to a single linked list
        public BST Remove(int value) {
            Remove(value, null);
            return this;
        }

        //this method will be used for deletion method to find the smallest value in the right-side subtree
        public int getMinValue() {
            if (left == null) {
                return this.value;
            } else {
                return left.getMinValue();
            }
        }

        public void Remove(int value, BST parent) {
            if (value < this.value) {
                if (left != null) {
                    left.Remove(value, this);
                }
            } else if (value > this.value) {
                if (right != null) {
                    right.Remove(value, this);
                }
            } else {
                if (left != null && right != null) {
                    this.value = right.getMinValue();
                    right.Remove(this.value, this);
                } else if (parent == null) {
                    //the root doesn't have parent node
                    if (left != null) {
                        this.value = left.value;
                        right = left.right;
                        left = left.left;
                    } else if (right != null) {
                        this.value = right.value;
                        left = right.left;
                        right = right.right;
                    } else {
                        // do nothing
                    }
                } else if (parent.left == this) {
                    parent.left = left != null ? left : right;
                } else if (parent.right == this) {
                    parent.right = left != null ? left : right;
                }
            }
        }


    }
}