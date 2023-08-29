using C_;

var queue = new MyQueue<int>();
queue.Insert(12);
queue.Insert(7);
queue.Insert(24);

queue.Show();

var num = 10;
var result = queue.Query(7, out var currentNode, out var previousNode);

Console.WriteLine($"\nNumber {num} found? " + result);
Console.WriteLine($"Previous node: {previousNode?.Value}");
Console.WriteLine($"Current node: {currentNode?.Value}");
Console.WriteLine();

queue.Remove();
queue.Remove();
queue.Remove();

queue.Show();