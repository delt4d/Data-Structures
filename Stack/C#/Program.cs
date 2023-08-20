using System.ComponentModel;
using C_;

var stack = new MyStack<int>();
var stop = false;

while (!stop)
{
    Console.Write("STACK [");
    for (var i = 0; i < stack.Length; i++) Console.Write(stack[i].Value + (i == stack.Length - 1 ? "" : ", "));
    Console.WriteLine("]\n");

    Console.WriteLine("Choose an option:");
    Console.WriteLine("(1) - Push");
    Console.WriteLine("(2) - Pop");
    Console.Write("(3) - Exit\n:");

    int input = int.Parse(Console.ReadLine() ?? "-1");

    if (input == 1)
    {
        Console.Write("-> ");
        stack.Push(int.Parse(Console.ReadLine() ?? "0"));
    }
    else if (input == 2)
    {
        Console.WriteLine("<- " + stack.Pop());
    }
    else if (input == 3)
    {
        stop = true;
    }
    else
    {
        Console.Beep();
        Console.WriteLine("Invalid option");
    }

    Console.Write("\n");
}