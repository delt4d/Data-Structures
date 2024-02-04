namespace CsharpQueue;

public class MyQueue<T>
{
    private Node<T>? Start { get; set; }
    private Node<T>? End { get; set; }
    private Node<T> GetNode(T value) => new Node<T>(value);

    public MyQueue()
    {
        Start = null;
        End = null;
    }

    public bool IsEmpty()
    {
        return Start == null || End == null;
    }

    public int Count()
    {
        var node = Start;

        int count = 0;

        while (node != null)
        {
            count++;
            node = node.Next;
        }

        return count;
    }

    public void Insert(T value)
    {
        var node = new Node<T>(value);

        if (IsEmpty())
        {
            Start = node;
            End = node;
            return;
        }

        End!.Next = node;
        End = node;
    }

    public void Remove()
    {
        if (!IsEmpty())
        {
            if (Start == End)
            {
                Start = null;
                End = null;
                return;
            }

            Start = Start!.Next;
        }
    }

    public bool Query(T value, out Node<T>? currentNode, out Node<T>? previousNode)
    {
        currentNode = Start;
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
        if (!IsEmpty())
        {
            Node<T>? aux = Start;

            var result = "";

            while (aux != null)
            {
                var isLastNode = aux.Next == null;
                result += string.Format("{0}{1}", aux.Value, !isLastNode ? " -> " : "");
                aux = aux.Next;
            }

            return string.Format("[START -> {0} -> END]", result);
        }

        return "[]";
    }
}