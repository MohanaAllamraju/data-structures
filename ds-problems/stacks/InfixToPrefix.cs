using System.Collections.Generic;

namespace ds_problems.stacks
{
    public class InfixToPrefix
    {
        public string ToPrefix(string infix)
        {
            var prefix = Reverse(infix);
            Stack<char> opStack = new Stack<char>();
            for (int i = 0; i < prefix.Length; i++)
            {

            }

            return prefix;
        }

        private int getPriority(char C)
        {
            if (C == '-' || C == '+')
                return 1;
            else if (C == '*' || C == '/')
                return 2;
            else if (C == '^')
                return 3;

            return 0;
        }

        private bool IsDigit(char ch)
        {
            return ch >= '0' && ch <= '9';
        }

        private bool IsOperator(char ch)
        {
            switch (ch)
            {
                case '+':
                case '-':
                case '*':
                case '%':
                case '/':
                    return true;
                default:
                    return false;
            }
        }

        public string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                var a = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = a;
            }

            return string.Concat(arr);
        }
    }
}