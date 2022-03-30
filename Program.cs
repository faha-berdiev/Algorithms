using System;

namespace Algorithms
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            PriorityQueue priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue("Faridun");
            priorityQueue.Enqueue("Kamila");
            priorityQueue.Enqueue("Nisso");
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
            Console.WriteLine(priorityQueue.Dequeue());
        }
    }
}