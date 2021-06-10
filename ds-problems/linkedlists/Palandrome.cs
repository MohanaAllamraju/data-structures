using System.Collections.Generic;

namespace ds_problems.linkedlists
{
    public class Paliandrome : LinkedList
    {
        public void Apply(Node head)
        {
            var stack = new Stack<int>();
            var pointer = head;
            while (pointer != null)
            {
                stack.Push(pointer.data);
                pointer = pointer.next;
            }
        }
    }
}