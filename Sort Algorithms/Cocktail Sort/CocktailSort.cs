using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class CocktailSort<T> : BaseAlgorithm<T>
        where T : IComparable
    {
        public override void Sort()
        {
            SwapCount = default;

            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                var swapCount = SwapCount;

                for(int i = left; i < right; i++)
                {
                    if(Compare(Items[i], Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;

                if (swapCount == SwapCount)
                {
                    break;
                }

                for (int j = right; j > left; j--)
                {
                    if(Compare(Items[j], Items[j - 1]) == -1)
                    {
                        Swap(j, j - 1);
                    }
                }
                left++;

                if (swapCount == SwapCount)
                {
                    break;
                }
            }
        }
    }
}
