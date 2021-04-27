using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Searching
{
    class Program
    {
        public static int BinSrch(List<int>lst, int target)
        {
            var min = 0;
            var max = lst.Count - 1;

            if (max < min)
            {
                return target;
            }
            else
            {
                var mid = lst.Count / 2;
               if(target ==  Math.Abs(mid))
                {
                    min = 55; 
                }
                else
                {
                    min = 404;
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);

            var value = BinSrch(lst, 3);
            Console.WriteLine("value: "+value);
        }
    }
}
