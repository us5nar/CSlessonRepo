using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson8.Sorting;


namespace Lesson8.Buffers
{
    interface iBuffer<T>:iPrintable<T>
// Buffer API :
//IsEmpty
//IsFull
//Peek
//Print - already exist from parent
    {
        bool IsEmpty();
        bool IsFull();
        T Peek(T[] buffer); 
    }
}
