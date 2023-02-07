using StackProject;

Stack stack = new Stack();

int item;
item = 42; Console.WriteLine($"Stack Push: {item}"); stack.Push(item);
item = 10; Console.WriteLine($"Stack Push: {item}"); stack.Push(item);
item = 23; Console.WriteLine($"Stack Push: {item}"); stack.Push(item);
item = 76; Console.WriteLine($"Stack Push: {item}"); stack.Push(item);
item = 44; Console.WriteLine($"Stack Push: {item}"); stack.Push(item);
item = 87; Console.WriteLine($"Stack Push: {item}"); stack.Push(item);

stack.Print();

if(!stack.IsEmpty()) 
{
    Console.WriteLine("Stack not empty!");
    Console.WriteLine($"Stack size: {stack.Size()}");
}

Console.WriteLine($"Stack Pop: {stack.Pop()}");
Console.WriteLine($"Stack Pop: {stack.Pop()}");

stack.Print();

if(!stack.IsFull()) 
{
    Console.WriteLine("Stack not full!");
    item = 50;
    Console.WriteLine($"Stack Push: {item}"); 
    stack.Push(item);
}

stack.Print();

Console.WriteLine($"Stack Peek: {stack.Peek()}");
stack.Print();

Console.WriteLine($"Stack Pop: {stack.Pop()}");
Console.WriteLine($"Stack Pop: {stack.Pop()}");
Console.WriteLine($"Stack Pop: {stack.Pop()}");
Console.WriteLine($"Stack Pop: {stack.Pop()}");
Console.WriteLine($"Stack Pop: {stack.Pop()}");

