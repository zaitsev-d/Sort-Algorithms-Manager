using System;
using System.Collections.Generic;
using Algorithm;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort<int> bubbleSort = new BubbleSort<int>();

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                bubbleSort.Items.Add(random.Next(0, 100));
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < bubbleSort.Items.Count; i++)
            {
                Console.Write(" " + bubbleSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Bubble Sort: ");
            bubbleSort.Sort();
            for (int i = 0; i < bubbleSort.Items.Count; i++)
            {
                Console.Write(" " + bubbleSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
