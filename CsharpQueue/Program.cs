using CsharpQueue;

var queue = new MyQueue<int>();
queue.Insert(1);
queue.Insert(2);
queue.Insert(3);
queue.Insert(4);

Console.WriteLine("Insert 1, 2, 3 and 4");
Console.WriteLine(queue.ToString() + "\n");

queue.Remove();
queue.Remove();

Console.WriteLine("Remove 3 elements");
Console.WriteLine(queue.ToString() + "\n");

queue.Insert(5);
queue.Insert(6);
queue.Insert(7);

Console.WriteLine("Insert 5, 6 and 7");
Console.WriteLine(queue.ToString() + "\n");

queue.Remove();
queue.Remove();
Console.WriteLine("Remove 2 elements");
Console.WriteLine(queue.ToString() + "\n");