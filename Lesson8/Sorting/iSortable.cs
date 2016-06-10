using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Sorting
{
    interface iSortable<T>:iPrintable<T>
    {
        T[] Sort(T[] ArrayToSort);
    }
}
