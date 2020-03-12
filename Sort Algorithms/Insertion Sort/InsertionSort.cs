using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class InsertionSort<T> : BaseAlgorithm<T>
        where T : IComparable
    {
        public override void Sort()
        {
            SwapCount = default;

            for(int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;

                while(j > 0 && Compare(temp, Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;

                    SwapCount++;
                }
                Items[j] = temp;
            }
        }
    }
}
