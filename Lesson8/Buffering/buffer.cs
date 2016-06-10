using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Buffering
{
    abstract class buffer<T>:IBuffer<T>
    {
        public abstract bool isEmpty(T[] inArray);
        public abstract bool isFull(T[] inArray);
        public abstract T Peek (T[] inArray);
        public void Print(T[] inArray)
        {

        }
    }
}
