namespace DSPractice.Queue
{
    internal class QueueWithLinkedList
    {
        Node front, rear;


        public void Enqueue(int value)
        {
            Node tempNode = new Node(value);
            if (IsEmpty())
            {
                front = rear = tempNode;
            }
            else
            {
                rear.next = tempNode;
                rear = rear.next;
            }
        }

        public int DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                Node temp = front;
                front = front.next;
                return temp.data;
            }
        }

        public bool IsEmpty()
        {
            return front is null;
        }
    }
}
