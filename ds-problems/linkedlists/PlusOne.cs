
namespace ds_problems.linkedlists
{
    public class PlusOneLinkedList : LinkedList
    {
        public void AddOne()
        {
            if (this.Head == null)
                return;

            this.Head = Reverse(this.Head);
            var pointer = this.Head;
            int carry = 1;
            while (pointer != null && carry > 0)
            {
                int sum = pointer.data + carry;
                pointer.data = sum % 10;
                carry = sum / 10;
                pointer = pointer.next;
            }

            pointer = this.Head;
            while (pointer.next != null)
            {
                pointer = pointer.next;
            }

            if (carry > 0)
            {
                var newNode = new Node(carry);
                pointer.next = newNode;
            }

            this.Head = Reverse(this.Head);
        }

        public Node Reverse(Node node)
        {
            Node prev = null;
            Node next = null;
            Node current = node;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            node = prev;
            return node;
        }
    }
}