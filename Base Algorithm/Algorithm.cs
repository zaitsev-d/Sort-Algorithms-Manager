using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class Algorithm<T> where T: IComparable
    {
        public List<T> Items { get; set; } = new List<T>();
        public void Swap(int first, int second)
        {
            if (first < Items.Count && second < Items.Count)
            {
                var temp = Items[first];
                Items[first] = Items[second];
                Items[second] = temp;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
