public class Solution {
    public bool IsValid(string s) {
        var stk = new Stack<char>();
        Dictionary<char, char> closeToOpen = new Dictionary<char, char> {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (var c in s){
            if (closeToOpen.ContainsKey(c)){
                if (stk.Count > 0 && stk.Peek() == closeToOpen[c]){
                    stk.Pop();
                } else {
                    return false;
                }
            } else {
                stk.Push(c);
            }
        }
        return stk.Count == 0;
    }
}
