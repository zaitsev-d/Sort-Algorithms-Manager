using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithm
{
    class StupidSort<T> : BaseAlgorithm<T>
        where T: IComparable
    {
        public override void Sort()
        {
            int i = default;

            while(i < Items.Count - 1)
            {
                if (Compare(Items[i + 1], Items[i]) == -1)
                {
                    Swap(i, i + 1);
                    i = default;
                }
                else i++;
            }
        }
    }
}
