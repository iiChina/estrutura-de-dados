using System;

namespace StackProject;

public class Stack 
{
    const int STACK_MAX_SIZE = 10;
    int top;
    int[] items = new int[STACK_MAX_SIZE];

    public Stack()
    {
        top = -1;
    }

    public void Push(int item)
    {
        if(top >= STACK_MAX_SIZE - 1)
            Console.WriteLine("Stack overflow!");
        else
        {
            top++;
            items[top] = item;
        }
    }

    public int Pop()
    {
        if(top <= -1)
        {
            Console.WriteLine("Stack underflow!");
            return -1;
        }
        else
        {
            return items[top--];
        }
    }

    public int Size()
    {
        return top + 1;
    }

    public bool IsEmpty()
    {
        return (top == -1) ? true : false;
    }

    public bool IsFull()
    {
        return (top == STACK_MAX_SIZE - 1) ? true : false;
    }

    public int Peek()
    {
        return (top == -1) ? -1 : items[top];
    }

    public void Print()
    {
        for(int i=top;i<=-1;i--)
        {
            Console.WriteLine(items[i]);
        }
    }
}