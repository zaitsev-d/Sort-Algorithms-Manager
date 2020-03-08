using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    public class BaseAlgorithm<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = default;
        public int ComparisonCount { get; protected set; } = default;

        public List<T> Items { get; set; } = new List<T>();
        public void Swap(int first, int second)
        {
            if (first < Items.Count && second < Items.Count)
            {
                var temp = Items[first];
                Items[first] = Items[second];
                Items[second] = temp;

                SwapCount++;
            }
        }

        public virtual void Sort()
        {
            SwapCount = default;
            Items.Sort();
        }
    }
}
