public class Program {
    //Store all the closing parentheses to dictionary
    //Store all the opening parentheses to stack
    //Count stack if it is 0, return true
    //Time Complexity: O(n) | Space Complexity: O(n)

    public bool ValidParentheses(string s) {
        Dictionary<char, char> parentheses = new Dictionary<char, char>();
        parentheses.Add(')', '(');
        parentheses.Add(']', '[');
        parentheses.Add('}', '{');

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