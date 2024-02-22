using CsharpStack;

var stack = new MyStack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine("Push 1, 2, 3 and 4");
Console.WriteLine(stack.ToString() + "\n");

stack.Pop();
stack.Pop();
stack.Pop();

Console.WriteLine("Pop 3 elements");
Console.WriteLine(stack.ToString() + "\n");

stack.Push(5);
stack.Push(6);
stack.Push(7);

Console.WriteLine("Insert 5, 6 and 7");
Console.WriteLine(stack.ToString() + "\n");

stack.Pop();
stack.Pop();

Console.WriteLine("Remove 2 elements");
Console.WriteLine(stack.ToString() + "\n");