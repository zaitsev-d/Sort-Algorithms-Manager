using System;

namespace SortAlgorithm
{
    class QuickSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public override void Sort() => Qsort(0, Items.Count - 1);

        private void Qsort(int left, int right)
        {
            if (left >= right) return;

            var pivot = Sorting(left, right);
            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            //The reference element is under the Right-address.
            for(int i = left; i <= right; i++)
            {
                if(Compare(Items[i], Items[right]) == -1)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }

            Swap(pointer, right);
            return pointer;
        }
    }
}
