using System;
using System.Linq;
using System.Collections.Generic;

public class Brace {

    public static bool validBraces(String braces) {
        if(braces.Length <= 0)
            return true;
      
        var stack = new Stack<char>(braces.Length);
        foreach(var item in braces)
        {
            switch(item)
            {
                case '(':
                case '{':
                case '[':
                    stack.Push(item);
                    break;
                case ')':                
                    if(stack.Count == 0 || stack.Pop()!='(')
                        return false;
                    break;
                case '}':
                    if(stack.Count == 0 || stack.Pop()!='{')
                        return false;
                    break;
                case ']':
                    if(stack.Count == 0 || stack.Pop()!='[')
                        return false;
                    break;
                default:
                    continue;
            }
        }
        if(stack.Count > 0)
            return false;
        return true;
    }
}