﻿using System;
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
            SelectionSort<int> selectionSort = new SelectionSort<int>();
            ShellSort<int> shellSort = new ShellSort<int>();
            StupidSort<int> stupidSort = new StupidSort<int>();
            GnomeSort<int> gnomeSort = new GnomeSort<int>();
            LSDRadixSort<int> lSDRadixSort = new LSDRadixSort<int>();
            MSDRadixSort<int> mSDRadixSort = new MSDRadixSort<int>();
            MergeSort<int> mergeSort = new MergeSort<int>();
            QuickSort<int> quickSort = new QuickSort<int>();

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                bubbleSort.Items.Add(random.Next(0, 100));
                cocktailSort.Items.Add(random.Next(0, 100));
                insertionSort.Items.Add(random.Next(0, 100));
                selectionSort.Items.Add(random.Next(0, 100));
                shellSort.Items.Add(random.Next(0, 100));
                stupidSort.Items.Add(random.Next(0, 100));
                gnomeSort.Items.Add(random.Next(0, 100));
                lSDRadixSort.Items.Add(random.Next(0, 100));
                mSDRadixSort.Items.Add(random.Next(0, 100));
                mergeSort.Items.Add(random.Next(0, 100));
                quickSort.Items.Add(random.Next(0, 100));
            }

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < bubbleSort.Items.Count; i++)
            {
                Console.Write(" " + bubbleSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Bubble Sort: ");
            var bubbleSortTime = bubbleSort.Timer();
            for (int i = 0; i < bubbleSort.Items.Count; i++)
            {
                Console.Write(" " + bubbleSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {bubbleSortTime.TotalMilliseconds}.");
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
            var cocktailSortTime = cocktailSort.Timer();
            for (int i = 0; i < cocktailSort.Items.Count; i++)
            {
                Console.Write(" " + cocktailSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {cocktailSortTime.TotalMilliseconds}.");
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
            var insertionSortTime = insertionSort.Timer();
            for (int i = 0; i < insertionSort.Items.Count; i++)
            {
                Console.Write(" " + insertionSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {insertionSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {insertionSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {insertionSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < selectionSort.Items.Count; i++)
            {
                Console.Write(" " + selectionSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Selection Sort: ");
            var selectionSortTime = selectionSort.Timer();
            for (int i = 0; i < selectionSort.Items.Count; i++)
            {
                Console.Write(" " + selectionSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {selectionSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {selectionSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {selectionSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < shellSort.Items.Count; i++)
            {
                Console.Write(" " + shellSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Shell Sort: ");
            var shellSortTime = shellSort.Timer();
            for (int i = 0; i < shellSort.Items.Count; i++)
            {
                Console.Write(" " + shellSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {shellSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {shellSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {shellSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < stupidSort.Items.Count; i++)
            {
                Console.Write(" " + stupidSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Stupid Sort: ");
            var stupidSortTime = stupidSort.Timer();
            for (int i = 0; i < stupidSort.Items.Count; i++)
            {
                Console.Write(" " + stupidSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {stupidSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {stupidSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {stupidSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < gnomeSort.Items.Count; i++)
            {
                Console.Write(" " + gnomeSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Gnome Sort: ");
            var gnomeSortTime = gnomeSort.Timer();
            for (int i = 0; i < gnomeSort.Items.Count; i++)
            {
                Console.Write(" " + gnomeSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {gnomeSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {gnomeSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {gnomeSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < lSDRadixSort.Items.Count; i++)
            {
                Console.Write(" " + lSDRadixSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("LSD Radix Sort: ");
            var lSDRadixSortTime = lSDRadixSort.Timer();
            for (int i = 0; i < lSDRadixSort.Items.Count; i++)
            {
                Console.Write(" " + lSDRadixSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {lSDRadixSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {lSDRadixSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {lSDRadixSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < mSDRadixSort.Items.Count; i++)
            {
                Console.Write(" " + lSDRadixSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("MSD Radix Sort: ");
            var mSDRadixSortTime = mSDRadixSort.Timer();
            for (int i = 0; i < mSDRadixSort.Items.Count; i++)
            {
                Console.Write(" " + mSDRadixSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {mSDRadixSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {mSDRadixSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {mSDRadixSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < mergeSort.Items.Count; i++)
            {
                Console.Write(" " + mergeSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Merge Sort: ");
            var mergeSortTime = mergeSort.Timer();
            for (int i = 0; i < mergeSort.Items.Count; i++)
            {
                Console.Write(" " + mergeSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {mergeSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {mergeSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {mergeSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("\n--------------------------");
            Console.WriteLine("Array: ");
            for (int i = 0; i < quickSort.Items.Count; i++)
            {
                Console.Write(" " + quickSort.Items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Quick Sort: ");
            var quickSortTime = quickSort.Timer();
            for (int i = 0; i < quickSort.Items.Count; i++)
            {
                Console.Write(" " + quickSort.Items[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Time: {quickSortTime.TotalMilliseconds}.");
            Console.WriteLine($"Swap Count: {quickSort.SwapCount}.");
            Console.WriteLine($"Comparison Count: {quickSort.ComparisonCount}.");
            Console.WriteLine("--------------------------\n");

            Console.ReadKey();
        }
    }
}
