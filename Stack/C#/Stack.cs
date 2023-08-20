namespace C_
{
    public class MyStack<T>
    {
        public Node<T>? Top { get; private set; }
        public int Length
        {
            get
            {
                var currentNode = Top;
                var currentIndex = 0;

                while (currentNode != null)
                {
                    currentNode = currentNode.Next;
                    ++currentIndex;
                }

                return currentIndex;
            }
        }
        public Node<T> this[int index]
        {
            get
            {
                if (index < 0) throw new IndexOutOfRangeException();

                var currentNode = Top;
                var currentIndex = 0;

                while (currentNode != null)
                {
                    if (currentIndex++ == index) return currentNode;
                    currentNode = currentNode.Next;
                }

                throw new IndexOutOfRangeException();
            }
        }
        public void Push(T value)
        {
            var newNode = new Node<T>(value);

            if (Top == null)
            {
                Top = newNode;
                return;
            }

            newNode.Next = Top;
            Top = newNode;
        }
        public T? Pop()
        {
            if (Top != null)
            {
                var value = Top.Value;
                Top = Top.Next;
                return value;
            }

            return default;
        }
    }
}