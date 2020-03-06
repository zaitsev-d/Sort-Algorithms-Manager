using System;
using System.Collections.Generic;

namespace Algorithm
{
    class BubbleSort<T> : Algorithm<T>
        where T: IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for(int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    var a = Items[j];
                    var b = Items[j + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
