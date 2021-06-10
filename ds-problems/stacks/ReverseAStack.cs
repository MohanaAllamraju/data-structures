using System.Collections.Generic;
using System.Linq;

namespace ds_problems.stacks
{
    public class ReverseAStack
    {
        public Stack<int> Stack { get; set; }

        public ReverseAStack()
        {
            this.Stack = new Stack<int>();
        }

        public void InsertAtBottom(int number)
        {
            if (this.Stack.Any())
            {
                int top = this.Stack.Pop();
                InsertAtBottom(number);
                Stack.Push(top);
                return;
            }

            Stack.Push(number);
        }

        public void Reverse()
        {
            if (this.Stack.Any())
            {
                int top = Stack.Pop();
                Reverse();
                InsertAtBottom(top);
            }
        }
    }
}