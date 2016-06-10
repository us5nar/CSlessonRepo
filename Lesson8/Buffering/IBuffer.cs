using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson8.Sorting;

namespace Lesson8.Buffering
{
    //IBuffer: ininherited from iPrintable
    //Buffer API
    //IsEmpty
    //IsFull
    //Peek
    //Print - already inherited from parent interface

    interface IBuffer<T>:iPrintable<T>
    {
        bool isEmpty(T[] inArray);
        bool isFull(T[] inArray);
        T Peek(T[] inArray);
    }
}
