namespace C_.MovieTheater
{
    public class MyQueue<T>
    {
        public Node<T>? Start { get; set; }
        public Node<T>? End { get; set; }

        public MyQueue()
        {
            Start = null;
            End = null;
        }

        public Node<T> GetNode(T value)
        {
            return new Node<T>(value);
        }

        public bool IsEmpty()
        {
            return this.Start == null || this.End == null;
        }

        public void Insert(T value)
        {
            Node<T> node = new(value);

            if (IsEmpty())
            {
                Start = node;
                End = node;
                return;
            }

            node.Next = this.Start;
            this.Start = node;
        }

        public void Remove()
        {
            if (!this.IsEmpty())
            {
                if (this.Start == this.End)
                {
                    this.Start = null;
                    this.End = null;
                    return;
                }

                Node<T>? currentNode = this.Start;
                Node<T>? previousNode = null;

                while (currentNode != null && currentNode != this.End)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }

                if (currentNode == this.End)
                {
                    previousNode!.Next = null;
                    this.End = previousNode;
                }
            }
        }

        public bool Query(T value, out Node<T>? currentNode, out Node<T>? previousNode)
        {
            currentNode = this.Start;
            previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Value!.Equals(value)) return true;
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            currentNode = null;
            previousNode = null;

            return false;
        }

        public void Show<TOut>(Func<T, TOut> func)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Node<T>? auxNode = this.Start!;

            Console.Write("Queue: [");
            while (auxNode != null)
            {
                var isLast = auxNode.Next == null;
                Console.Write(func(auxNode.Value) + (isLast ? "" : " -> "));
                auxNode = auxNode.Next;
            }
            Console.WriteLine("]");
        }
    }
}