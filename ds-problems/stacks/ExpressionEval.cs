using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ds_problems.stacks
{
    public class ExpressionEval
    {
        public int Eval(string expression)
        {
            char[] tokens = expression.ToCharArray();
            Stack<int> intergerStack = new Stack<int>();
            Stack<char> opStack = new Stack<char>();
            for (int i = 0; i < tokens.Length; i++)
            {
                char c = tokens[i];
                if (c == ' ')
                    continue;

                else if (c == '(')
                    opStack.Push(c);

                else if (c == ')')
                {
                    while (opStack.Peek() != '(')
                    {
                        intergerStack.Push(applyOp(opStack.Pop(),
                                         intergerStack.Pop(),
                                        intergerStack.Pop()));
                    }
                    opStack.Pop();
                }

                else if (c >= '0' && c <= '9')
                {
                    StringBuilder sb = new StringBuilder();
                    while (i < tokens.Length &&
                        tokens[i] >= '0' &&
                            tokens[i] <= '9')
                    {
                        sb.Append(tokens[i++]);
                    }

                    intergerStack.Push(int.Parse(sb.ToString()));
                    i--;
                }

                else if (c == '+' || c == '-' || c == '*' || c == '/' || c == '%')
                {
                    while (opStack.Count > 0 &&
                                             hasPrecedence(tokens[i],
                                                         opStack.Peek()))
                    {
                        intergerStack.Push(applyOp(opStack.Pop(),
                                         intergerStack.Pop(),
                                       intergerStack.Pop()));
                    }

                    opStack.Push(c);
                }
            }

            while (opStack.Count > 0)
            {
                intergerStack.Push(applyOp(opStack.Pop(),
                                 intergerStack.Pop(),
                                intergerStack.Pop()));
            }

            return intergerStack.Any() ? intergerStack.Pop() : 0;
        }

        private bool hasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/' || op1 == '%') &&
                   (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int applyOp(char op, int a, int b)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new
               System.Exception(
                      "Cannot divide by zero");
                    }
                    return a / b;
                case '%':
                    return a % b;
            }

            return 0;
        }
    }
}