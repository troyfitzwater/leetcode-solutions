const string s1 = "()";
const string s2 = "()[]{}";
const string s3 = "(]";
const string s4 = "([])"; // stack would be in order: [, ( then when we get to a closing bracket, we'll check the first from the stack to see if it matches
const string s5 = "((";
const string s6 = "){";

Console.WriteLine(IsValidParentheses(s1));
Console.WriteLine(IsValidParentheses(s2));
Console.WriteLine(IsValidParentheses(s3));
Console.WriteLine(IsValidParentheses(s4));
Console.WriteLine(IsValidParentheses(s5));
Console.WriteLine(IsValidParentheses(s6));
return;

bool IsValidParentheses(string s)
{
    if (s.Length % 2 != 0)
    {
        return false;
    }
    
    var characters = s.ToCharArray();

    // stacks are LIFO: last-in first-out
    var stack = new Stack<char>();

    foreach (var character in characters)
    {
        if (character is '(' or '[' or '{')
        {
            stack.Push(character);
        }
        else
        {
            if (stack.Count == 0) return false;
            
            var topOfStack = stack.Pop();
            // if it is a closing bracket, we need to check the top of the stack, if its valid it will match
            switch (character)
            {
                case ')':
                    if (topOfStack != '(') return false;
                    break;
                case ']':
                    if (topOfStack != '[') return false;
                    break;
                case '}':
                    if (topOfStack != '{') return false;
                    break;
            }
        }
    }

    return stack.Count == 0;
}
