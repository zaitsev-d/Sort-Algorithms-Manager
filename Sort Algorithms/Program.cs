using System;
using System.Collections.Generic;
using SortAlgorithm;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            CocktailSort<int> cocktailSort = new CocktailSort<int>();
            InsertionSort<int> insertionSort = new InsertionSort<int>();

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                bubbleSort.Items.Add(random.Next(0, 100));
                cocktailSort.Items.Add(random.Next(0, 100));
                insertionSort.Items.Add(random.Next(0, 100));
            }

            Console.WriteLine("\n--------------------------");
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
            Console.WriteLine($"Swap Count: {bubbleSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {bubbleSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < cocktailSort.Items.Count; i++)
            {
                Console.Write(" " + cocktailSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Cocktail Sort: ");
            cocktailSort.Sort();
            for (int i = 0; i < cocktailSort.Items.Count; i++)
            {
                Console.Write(" " + cocktailSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Swap Count: {cocktailSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {cocktailSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < insertionSort.Items.Count; i++)
            {
                Console.Write(" " + insertionSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Insertion Sort: ");
            insertionSort.Sort();
            for (int i = 0; i < insertionSort.Items.Count; i++)
            {
                Console.Write(" " + insertionSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Swap Count: {insertionSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {insertionSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.ReadKey();
        }
    }
}
