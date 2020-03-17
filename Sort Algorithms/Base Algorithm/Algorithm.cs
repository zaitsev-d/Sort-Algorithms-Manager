using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortAlgorithm
{
    public class BaseAlgorithm<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = default;
        public int ComparisonCount { get; protected set; } = default;

        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwapEvent;

        public List<T> Items { get; set; } = new List<T>();
        public void Swap(int first, int second)
        {
            if (first < Items.Count && second < Items.Count)
            {
                SwapEvent?.Invoke(this, new Tuple<T, T>(Items[first], Items[second]));
                SwapCount++;

                var temp = Items[first];
                Items[first] = Items[second];
                Items[second] = temp;
            }
        }

        public TimeSpan Timer()
        {
            var timer = new Stopwatch();
            SwapCount = default;

            timer.Start();
            Sort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            ComparisonCount++;

            return a.CompareTo(b);
        }

        public virtual void Sort()
        {
            SwapCount = default;
            Items.Sort();
        }
    }
}
