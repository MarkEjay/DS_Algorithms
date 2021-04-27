using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class InsertionSort
    {
        // 3, 65, 3, 6, 23, 5, 2, 6
        //public static void sort(int[] array)
        //{
        //    for (var i = 1; i < array.Length; i++)
        //    {
        //        var current = array[i];
        //        var j = i - 1;
        //        while (j >= 0 && array[j] > current)
        //        {
        //            array[j + 1] = array[j];
        //            j--;
        //        }
        //        array[j + 1] = current;
        //    }
        //}

    public static void sort(int[] a)
        {
            for(int i = 1; i<a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;
                while(j>=0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }

        public static void reSort(int[] a)
        {
            for(int i=1; i<a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;
               
                while(j>=0 && a[j] < key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
        static int[] numbers = { 1,4,2,5,3};
        static void Main(string[] args)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                reSort(numbers);

                Console.WriteLine(numbers[i]);
            }
        }
    }


}
