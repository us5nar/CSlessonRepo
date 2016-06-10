using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Sorting
{
    abstract class Sorter<T>:iSortable<T>
        // Inherits Print and sort from interfaces
        //implements swap and inherited Print
    {
        public abstract T[] Sort(T[] arrayToSort);
        public void Print(T[] arrayToPrint)
        {
            Console.WriteLine("_____________SORTED_______________");
            foreach (T element in arrayToPrint)
            {
                Console.WriteLine("{0,6}", element);
            }
        }
        protected T[] Swap(T[] arrayToSwap, int indexA, int indexB)
        {
            T temp = arrayToSwap[indexA];
            arrayToSwap[indexA] = arrayToSwap[indexB];
            arrayToSwap[indexB] = temp;
            return arrayToSwap;
        }



       
    }
}
