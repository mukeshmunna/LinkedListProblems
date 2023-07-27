using LinkedListProblem;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Queue Fuction");
        LinKedListQueue queue = new LinKedListQueue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
        queue.Display();
        queue.Dequeue();
        queue.Display();

    }
}
