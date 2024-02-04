using C_.MovieTheater;

static void FindNode<T>(MyQueue<T> queue, T num)
{
    var result = queue.Query(num, out var currentNode, out var previousNode);

    Console.WriteLine($"\nNumber {num} found? " + result);

    if (result == true)
    {
        Console.WriteLine($"Previous node: {(previousNode != null ? previousNode.Value : "")}");
        Console.WriteLine($"Current node: {currentNode!.Value}");
    }
}

var queue = new MyQueue<int>();
queue.Insert(12);
queue.Insert(7);
queue.Insert(24);

queue.Show(item => item);

FindNode(queue, 2);
FindNode(queue, 24);
FindNode(queue, 132);
FindNode(queue, 7);

Console.WriteLine();

queue.Remove();
queue.Remove();
queue.Remove();

queue.Show(item => item);