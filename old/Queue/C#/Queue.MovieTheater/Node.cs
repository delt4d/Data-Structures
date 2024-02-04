namespace C_.MovieTheater
{
    public class Node<T>
    {
        public readonly T Value;
        public Node<T>? Next { get; set; }
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }
}