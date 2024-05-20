namespace Balanced_Brackets
{
    public class BalancedBracketsChecker
    {
        public static bool AreBracketsBalanced(string expression)
        {
            var stack = new Stack<char>();

            foreach (var ch in expression)
            {
                switch (ch)
                {
                    case '{':
                    case '(':
                    case '[':
                        stack.Push(ch);
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{') return false;
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Pop() != '(') return false;
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[') return false;
                        break;
                    case >= 'a' and <= 'z': 
                    case >= 'A' and <= 'Z': 
                        throw new ArgumentException("Wrong argument, please use only brackets!");
                }
            }

            // if the count of stack is 0 => then all brackets were matched, else it's not balance.
            return stack.Count == 0;
        }
    }
}
