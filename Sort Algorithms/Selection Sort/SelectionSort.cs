﻿using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class SelectionSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public override void Sort()
        {
            var minIndex = 0;
            for(int i = 0; i < Items.Count - 1; i++)
            {
                minIndex = i;
                for(int j = i + 1; j < Items.Count; j++)
                {
                    if(Compare(Items[j], Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if(i != minIndex) Swap(i, minIndex);
            }
        }
    }
}
