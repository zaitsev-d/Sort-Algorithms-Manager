﻿using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class BubbleSort<T> : BaseAlgorithm<T>
        where T : IComparable
    {
        public override void Sort()
        {
            SwapCount = default;
            var count = Items.Count;

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    if (Compare(a, b) == 1)
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
