using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class GnomeSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public override void Sort()
        {
            var i = 1;

            while(i < Items.Count)
            {
                if (i == 0 || Compare(Items[i], Items[i - 1]) != -1) i++;
                else
                {
                    Swap(i, i - 1);
                    i--;
                }
            }
        }
    }
}
