using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class ShellSort<T> : BaseAlgorithm<T>
        where T : IComparable
    {
        public override void Sort()
        {
            SwapCount = default;
            var step = Items.Count / 2;

            while(step > 0)
            {
                for(int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while(j >= step && Compare(Items[j - step], Items[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}
