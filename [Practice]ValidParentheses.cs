public class Program {
    //Time Complexity: O(n) | Space Complexity: O(1)
    public bool ValidParentheses(string s) {
        Dictionary<char, char> parentheses = new Dictionary<char, char> {{')', '('}, {']', '['}, {'}', '{'}};
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (parentheses.ContainsKey(c)) {
                char topElement = stack.Count == 0 ? '#' : stack.Pop();
                if (topElement != parentheses[c]) {
                    return false;
                }
            } else {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}