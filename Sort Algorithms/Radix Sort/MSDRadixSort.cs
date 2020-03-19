using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class MSDRadixSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public override void Sort()
        {
            int length = GetMaxLength(Items);
            var result = SortCollection(Items, length - 1);

            for (int i = 0; i < result.Count; i++) Set(i, result[i]);
        }

        private List<T> SortCollection(List<T> collection, int step)
        {
            var result = new List<T>();
            var groups = new List<List<T>>();
            for(int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            //distribution of elements by buckets
            foreach(var item in collection)
            {
                var i = item.GetHashCode();
                var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                groups[value].Add(item);
            }

            //assembly of elements
            foreach(var group in groups)
            {
                if(group.Count > 1 && step > 0)
                {
                    result.AddRange(SortCollection(group, step - 1));
                    continue;
                }

                result.AddRange(group);
            }

            return result;
        }

        private int GetMaxLength(List<T> collection)
        {
            int length = 0;
            foreach (var item in collection)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Bitwise sorting only supports integers(greater than or equal to zero)", nameof(Items));
                }

                var l = item.GetHashCode().ToString().Length;
                if (l > length) length = l;
            }

            return length;
        }
    }
}
