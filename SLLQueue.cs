namespace DSA
{
    public class SLLQueue
    {
        private SinglyLinkedList queue;
        public SLLQueue()
        {
            queue = new SinglyLinkedList();
        }
        public void Enqueue(int data)
        {
            queue.AppendList(data);
        }
        public void DisplayQueue()
        {
            if (queue.Head != null)
            {
                SLLNode? iterator = queue.Head;
                for (int i = 0; i < SinglyLinkedList.Count; ++i)
                {
                    Console.Write($"{iterator.Data}-");
                    iterator = iterator.Next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Queue Status : {isEmpty()}");
            }
        }

        public void Dequeue()
        {
            queue.DeletListNode(1);
        }

        public string Peek()
        {
            if (queue.Head != null)
                return queue.Head.Data.ToString();

            return isEmpty();
        }

        public string isEmpty()
        {
            if (SinglyLinkedList.Count == 0)
                return "Empty";

            return "Not Empty";
        }
        public string Size()
        {
            return SinglyLinkedList.Count.ToString();
        }
    }
}