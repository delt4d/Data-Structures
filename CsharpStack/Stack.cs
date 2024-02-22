namespace CsharpStack;

public class MyStack<T>
{
    private Node<T>? Top { get; set; }
    private static Node<T> GetNode(T value) => new Node<T>(value);

    public MyStack()
    {
        Top = null;
    }

    public bool IsEmpty()
    {
        return Top == null;
    }

    public T? GetTop()
    {
        return !IsEmpty() ? Top!.Value : default;
    }

    public void Push(T value)
    {
        var newNode = GetNode(value);
        if (!IsEmpty()) newNode.Next = Top;
        Top = newNode;
    }

    public T? Pop()
    {
        if (!IsEmpty())
        {
            var value = Top!.Value;
            Top = Top.Next;
            return value;
        }

        return default;
    }

    public bool Query(T value, out Node<T>? currentNode, out Node<T>? previousNode)
    {
        currentNode = Top;
        previousNode = null;

        while (currentNode != null)
        {
            if (currentNode.Value!.Equals(value))
                return true;

            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        currentNode = null;
        previousNode = null;

        return false;
    }

    public override string ToString()
    {
        if (IsEmpty()) return "[]";

        Node<T>? aux = Top;

        string result = "";

        while (aux != null)
        {
            var isLastNode = aux.Next == null;
            result += string.Format("{0}{1}", aux.Value, !isLastNode ? " -> " : "");
            aux = aux.Next;
        }

        return string.Format("[START -> {0} -> END]", result);
    }
}
