public class Solution {
    public bool IsValid(string s) {
            Stack<char> stack = new Stack<char>();
            foreach (char bracket in s)
            {
                if ("{([".Contains(bracket))
                {
                    stack.Push(bracket);
                }
                else if (stack.Count == 0 || s.Length < 1)
                {
                    return false;
                }
                else if (Array.IndexOf("{([".ToArray(), stack.Pop()) != Array.IndexOf("})]".ToArray(), bracket))
                {
                        return false;
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;
    }
}
