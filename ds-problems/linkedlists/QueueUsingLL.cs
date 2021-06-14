namespace ds_problems.linkedlists
{
    public class QueueUsingLL
    {
        Node front;

        Node rear;

        public void Enqueue(int data)
        {
            var newNode = new Node(data);
            if (rear == null && front == null)
            {
                rear = newNode;
                front = rear;
            }
            else
            {
                rear.next = newNode;
                rear = rear.next;
            }
        }

        public void Dequeue()
        {
            if (rear == null && front == null)
            {
                throw new System.Exception("Queue is empty");
            }

            front = front.next;
        }

        public int Peek()
        {
            return this.front.data;
        }
    }
}