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
                    if(Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                        ComparisonCount++;
                    }
                }
                right--;

                if (swapCount == SwapCount)
                {
                    break;
                }

                for (int j = right; j > left; j--)
                {
                    if(Items[j].CompareTo(Items[j - 1]) == -1)
                    {
                        Swap(j, j - 1);
                        ComparisonCount++;
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
