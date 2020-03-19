using System;
using System.Collections.Generic;

namespace SortAlgorithm
{
    class LSDRadixSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public override void Sort()
        {
            var groups = new List<List<T>>();
            for(int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length = GetMaxLength();
            for(int step = 0; step < length; step++)
            {
                foreach(var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }

                var j = 0;
                //assembly of elements
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Set(j, item);
                        j++;
                    }
                }

                //clearing buckets
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            int length = 0;
            foreach(var item in Items)
            {
                if(item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Bitwise sorting only supports integers (greater than or equal to zero)", nameof(Items));
                }

                var l = item.GetHashCode().ToString().Length;
                if (l > length) length = l;
            }

            return length;
        }
    }
}
