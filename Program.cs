﻿
using System.Collections;

namespace prjQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");
            Console.WriteLine("myQ");
            Console.WriteLine("\t Count: {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues(myQ);
            Console.WriteLine(myQ.Dequeue().ToString());
            PrintValues(myQ);
        }

        private static void PrintValues(Queue myQ)
        {
            foreach (var item in myQ)
            {
                Console.Write("\t{0}", item);
            }
            Console.WriteLine();
        }
    }
}
