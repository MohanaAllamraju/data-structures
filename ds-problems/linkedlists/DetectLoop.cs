using System.Collections.Generic;
using System;

namespace ds_problems.linkedlists
{
    public class DetectLoop : LinkedList
    {
        public bool HasLoop(Node firstNode)
        {
            HashSet<Node> hashset = new HashSet<Node>();
            while (firstNode != null)
            {
                if (hashset.Contains(firstNode))
                    return true;

                hashset.Add(firstNode);
                firstNode = firstNode.next;
            }

            return false;
        }

        public bool HasLoop(bool deleteLoop = false)
        {
            Node slow_p = this.Head;
            Node fast_p = this.Head;
            bool flag = false;
            while (slow_p != null && fast_p != null
               && fast_p.next != null)
            {
                slow_p = slow_p.next;
                fast_p = fast_p.next.next;
                if (slow_p == fast_p)
                {
                    if (deleteLoop)
                    {
                        DeleteLoop(slow_p, this.Head);
                    }
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public void DeleteLoop(Node slowNode, Node head)
        {
            Node ptr1 = null, ptr2 = null;
            ptr1 = head;
            while (true)
            {
                ptr2 = slowNode;
                while (ptr2.next != slowNode && ptr2.next != ptr1)
                {
                    ptr2 = ptr2.next;
                }

                if (ptr2.next == ptr1)
                {
                    break;
                }

                ptr1 = ptr1.next;
            }

            ptr2.next = null;
        }

        public Node detectAndFindFirstLoop(Node head)
        {
            Node slow = this.Head;
            Node fast = this.Head;
            while (slow != null && fast != null
               && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    break;
                }
            }

            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }
}