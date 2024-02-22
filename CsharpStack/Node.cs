namespace CsharpStack;

public class Node<T>(T value)
{
    public T Value { get; } = value;
    public Node<T>? Next { get; set; }
}